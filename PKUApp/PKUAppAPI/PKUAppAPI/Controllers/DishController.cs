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

        private static int pagesize = 6;

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

            dishpro.UserId = user.Id;

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

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            dishpro.UserId = user.Id;

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


        [HttpDelete("DeleteAllDishProducts")]
        public async Task<ActionResult<UserProductDish>> DeleteAllDishProducts()
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var dishproducts = await _context.UserProductDish.Where(a => a.UserId == user.Id).ToListAsync();

            foreach (var dishprod in dishproducts)
            {
                _context.UserProductDish.Remove(dishprod);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }


        [HttpPost("CreateDish")]
        public async Task<IActionResult> CreateDish(string name="")
        {

            if (name.Length<1)
            {
                ModelState.AddModelError("Name", "Name is required");
                return BadRequest(ModelState);
            }

            var check = _context.Products.Any(e => e.Name == name && e.UserId == null);
            if (check == true)
            {
                ModelState.AddModelError("Name", "Name already in use");
                return BadRequest(ModelState);
            }

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var owncheck = _context.Products.Any(e => e.Name == name && e.UserId == user.Id);
            if (owncheck == true)
            {
                ModelState.AddModelError("Name", "Name already in use in your Own Products");
                return BadRequest(ModelState);
            }

            var dproducts = await _context.UserProductDish.Where(a => a.UserId == user.Id).ToListAsync();

            var Product = new Product();
            Product.Name = name;
            int Weight = 0;

            foreach (var dishprod in dproducts)
            {
                var prod = await _context.Products.FindAsync(dishprod.ProductId);
                Product.Phe += (int)((prod.Phe / 100 * dishprod.Weight / 100));
                Product.Calories += (int)((prod.Calories / 100 * dishprod.Weight / 100));
                Product.Protein += (int)((prod.Protein / 100 * dishprod.Weight / 100));
                Product.Fat += (int)((prod.Fat / 100 * dishprod.Weight / 100));
                Product.Carb += (int)((prod.Carb / 100 * dishprod.Weight / 100));
                Weight += dishprod.Weight;
            }

            Product.Phe = (Product.Phe * 100 ) / (Weight / 100);
            Product.Calories = (Product.Calories * 100) / (Weight / 100);
            Product.Protein = (Product.Protein * 100) / (Weight / 100);
            Product.Fat = (Product.Fat * 100) / (Weight / 100);
            Product.Carb = (Product.Carb * 100) / (Weight / 100);

            Product.Category = "Dishes";

            Product.UserId = user.Id;

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            var dishproducts = await _context.UserProductDish.Where(a => a.UserId == user.Id).ToListAsync();

            foreach (var dishprod in dishproducts)
            {
                _context.UserProductDish.Remove(dishprod);
                await _context.SaveChangesAsync();
            }

            return NoContent();

        }

    }
}