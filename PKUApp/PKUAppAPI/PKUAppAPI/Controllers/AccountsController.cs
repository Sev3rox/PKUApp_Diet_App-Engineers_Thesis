using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PKUAppAPI.DTO;
using PKUAppAPI.JwtFeatures;
using PKUAppAPI.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly JwtHandler _jwtHandler;
        private readonly PKUAppDbContext _context;

        public AccountsController(UserManager<User> userManager, IMapper mapper, JwtHandler jwtHandler, PKUAppDbContext context)
        {
            _userManager = userManager;
            _mapper = mapper;
            _jwtHandler = jwtHandler;
            _context = context;
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            if (userForRegistration == null || !ModelState.IsValid)
                return BadRequest();

            var user = _mapper.Map<User>(userForRegistration);

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);

                return BadRequest(new RegistrationResponseDto { Errors = errors });
            }

            var limits = new UserDailyLimits
            {
                UserId=user.Id
            };

            _context.UserDailyLimits.Add(limits);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }



        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDto userForAuthentication)
        {
            var user = await _userManager.FindByNameAsync(userForAuthentication.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, userForAuthentication.Password))
                return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });

            var signingCredentials = _jwtHandler.GetSigningCredentials();
            var claims = await _jwtHandler.GetClaims(user);
            var tokenOptions = _jwtHandler.GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token });
        }

        [HttpGet("GetName")]
        public JsonResult GetName()
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user= _context.Users.FirstOrDefault(a => a.Email == claims[0].Value);
            return new JsonResult(user.Name);
        }

        [HttpGet("IsAdmin")]
        public JsonResult IsAdmin()
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }
            if(claims[1].Value=="Administrator")
            return new JsonResult(true);
            else
                return new JsonResult(false);
        }

        [HttpPut("ChangeName")]
        [Authorize]
        public async Task<ActionResult<List<string>>> ChangeName(string name="")
        {
            if (name == "")
            {
                ModelState.AddModelError("Name", "Name is required");
                return BadRequest(ModelState);
            }

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            user.Name = name;

            _context.Entry(user).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            
            return NoContent();
        }

        [HttpPut("GetLimits")]
        [Authorize]
        public async Task<ActionResult<UserDailyLimits>> ChangeLimits()
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            return await _context.UserDailyLimits.FirstOrDefaultAsync(a=>a.UserId==user.Id);
        }

        [HttpPut("ChangeLimits")]
        [Authorize]
        public async Task<ActionResult<List<string>>> ChangeLimits(UserDailyLimits limits)
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }

            _context.Entry(limits).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

