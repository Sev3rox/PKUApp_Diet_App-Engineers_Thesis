using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PKUAppAPI.Models;

namespace PKUAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DishController : ControllerBase
    {
        public class Result<T>
        {
            public int Count { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public List<T> Items { get; set; }
        }
        public class ProductDish
        {
            public int Weight { get; set; }
            public Product Product { get; set; }
        }

        private static int pagesize = 8;

        private readonly PKUAppDbContext _context;

        public DishController(PKUAppDbContext context)
        {
            _context = context;
        }

        [HttpPost("AddProductToDish")]
        public async Task<IActionResult> AddProductToDish(UserProductDish dishpro)
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            _context.UserProductDish.Add(dishpro);
            await _context.SaveChangesAsync();

            return NoContent();

        }

    }
}