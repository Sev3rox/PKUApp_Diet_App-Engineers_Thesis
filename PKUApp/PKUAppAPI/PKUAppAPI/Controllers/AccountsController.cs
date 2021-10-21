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
using PKUAppAPI.Data;

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

        [HttpPut("ChangeSettings")]
        [Authorize]
        public async Task<ActionResult<List<string>>> ChangeSettings(string name="")
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

        [HttpGet("GetLimits")]
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

        [HttpPut("ChangeLimits/{id}")]
        [Authorize]
        public async Task<ActionResult<List<string>>> ChangeLimits(int id, UserDailyLimits limits)
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            if (user.Id != limits.UserId)
            {
                return new JsonResult("Not your limits");
            }

            limits.UserId = user.Id;

            if (id != limits.UserDailyLimitsId)
            {
                return BadRequest();
            }

            _context.Entry(limits).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("ResetLimits")]
        [Authorize]
        public async Task<ActionResult<List<string>>> ResetLimits()
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var limits = await _context.UserDailyLimits.FirstOrDefaultAsync(a => a.UserId == user.Id);
            limits.PheLimit = 0;
            limits.CaloriesLimit = 0;
            limits.ProteinLimit = 0;
            limits.FatLimit = 0;
            limits.CarbLimit = 0;

            _context.Entry(limits).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("GetMedicine")]
        [Authorize]
        public async Task<ActionResult<UserMedicine>> GetMedicine()
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            return await _context.UserMedicines.FirstOrDefaultAsync(a => a.UserId == user.Id && a.EndDate==null);
        }

        [HttpPost("AddMedicine")]
        [Authorize]
        public async Task<ActionResult<UserMedicine>> AddMedicine(UserMedicine med, DateTime date)
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var helpdate = new DateTime(date.Year, date.Month, date.Day);

            med.UserId = user.Id;
            med.StartDate = helpdate;

            _context.UserMedicines.Add(med);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("DeleteMedicine")]
        [Authorize]
        public async Task<ActionResult<List<string>>> AddMedicine(int id, DateTime date)
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var helpdate = new DateTime(date.Year, date.Month, date.Day);

            var med = _context.UserMedicines.Find(id);

            if (user.Id != med.UserId)
            {
                return new JsonResult("Not your medicine");
            }

            med.EndDate = helpdate;

            _context.Entry(med).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("PutMedicine")]
        [Authorize]
        public async Task<ActionResult<List<string>>> PutMedicine(UserMedicine medicine, int id, DateTime date)
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(false);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var helpdate = new DateTime(date.Year, date.Month, date.Day);

            var med = _context.UserMedicines.Find(id);

            if (user.Id != med.UserId)
            {
                return new JsonResult("Not your medicine");
            }

            med.EndDate = helpdate;

            _context.Entry(med).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            medicine.UserId = user.Id;
            medicine.StartDate = helpdate;
            medicine.UserMedicineId = 0;

            _context.UserMedicines.Add(medicine);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

