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


        [HttpPut("EditProductToDish")]
        public async Task<IActionResult> EditProductToDish(UserProductDish dishpro)
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            _context.Entry(dishpro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return new JsonResult(null);
            }

            return NoContent();

        }


        [HttpGet("GetDishProducts")]
        public async Task<ActionResult<Result<ProductDish>>> GetDishProducts(int page = 1)
        {
            List<ProductDish> dishproducts = new List<ProductDish>();

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var dproducts = await _context.UserProductDish.Where(a => a.UserId == user.Id).ToListAsync();

            foreach (var dishprod in dproducts)
            {
                var prod = await _context.Products.FindAsync(dishprod.ProductId);
                var temp = new ProductDish
                {
                    Product = prod,
                    Weight = dishprod.Weight
                };
                dishproducts.Add(temp);
            }

            Result<ProductDish> result = new Result<ProductDish>
            {
                Count = dishproducts.Count(),
                PageIndex = page,
                PageSize = pagesize,
                Items = dishproducts.Skip((page - 1) * pagesize).Take((pagesize)).ToList()
            };

            return result;

        }


        [HttpDelete("DeleteDishProducts")]
        public async Task<ActionResult<UserProductDish>> DeleteDishProducts(int productid)
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var dishpro = await _context.UserProductDish.FirstOrDefaultAsync(a => a.UserId == user.Id && a.ProductId == productid);
            _context.UserProductDish.Remove(dishpro);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpGet("GetDishSummary")]
        public async Task<ActionResult<ProductDish>> GetDishSummary()
        {
            List<ProductDish> dishproducts = new List<ProductDish>();

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var dproducts = await _context.UserProductDish.Where(a => a.UserId == user.Id).ToListAsync();

            var summary = new ProductDish
            {
                Product = new Product(),
                Weight = 0
            };

            foreach (var dishprod in dproducts)
            {
                var prod = await _context.Products.FindAsync(dishprod.ProductId);
                summary.Product.Phe += (int)((prod.Phe / 100 * dishprod.Weight / 100));
                summary.Product.Calories += (int)((prod.Calories / 100 * dishprod.Weight / 100));
                summary.Product.Protein += (int)((prod.Protein / 100 * dishprod.Weight / 100));
                summary.Product.Fat += (int)((prod.Fat / 100 * dishprod.Weight / 100));
                summary.Product.Carb += (int)((prod.Carb / 100 * dishprod.Weight / 100));
                summary.Weight += dishprod.Weight;
            }

            return summary;

        }

    }
}