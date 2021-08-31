using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PKUAppAPI.Models;

namespace PKUAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly PKUAppDbContext _context;

        public ProductsController(PKUAppDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.Where(a => a.UserId == null).ToListAsync();
        }

        [HttpGet("GetProductsByCategory/{name}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByCategory(string name)
        {
            return await _context.Products.Where(a => a.UserId == null && a.Category == name).ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            var check = _context.Products.Any(e => e.Name == product.Name && e.ProductId != product.ProductId && e.UserId == null);
            if (check == true)
            {
                ModelState.AddModelError("Name", "Name already in use");
                return BadRequest(ModelState);
            }
            else
            {
                if (id != product.ProductId)
                {
                    return BadRequest();
                }

                _context.Entry(product).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            var check = _context.Products.Any(e => e.Name == product.Name && e.UserId == null);
            if (check == true)
            {
                ModelState.AddModelError("Name", "Name already in use");
                return BadRequest(ModelState);
            }
            else
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
            }
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        [Route("GetAllCategories")]
        [HttpGet]
        public async Task<ActionResult<List<string>>> GetAllCategories()
        {
            var categories = await _context.Categories.Select(a => a.Name).ToListAsync();

            if (categories == null)
            {
                return NotFound();
            }

            return categories;
        }

        [HttpGet("GetUserProducts")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Product>>> GetUserProducts(string search=null, string sort=null, bool asc=false)
        {

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            List<Product> list = new List<Product>();
            List<Product> ownlist = new List<Product>();
            List<UserProductFav> favlist = new List<UserProductFav>();

                list = await _context.Products.Where(a => a.UserId == null && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

                ownlist = await _context.Products.Where(a => a.UserId == user.Id && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

                favlist = await _context.UserProductFavs.Where(a => a.UserId == user.Id).ToListAsync();

            list.AddRange(ownlist);

            if (sort != null)
            {
               if(asc==true)
                    list = list.OrderBy(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
                else
                    list = list.OrderByDescending(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();

            }

            foreach (Product prod in list)
            {
                if (favlist.Any(a => a.ProductId == prod.ProductId))
                {
                    prod.isFav = true;
                }
            }

            return list;
        }

        [HttpGet("GetUserOwnProducts")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Product>>> GetUserOwnProducts()
        {

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var ownlist = await _context.Products.Where(a => a.UserId == user.Id).ToListAsync();


            return ownlist;
        }

        [HttpDelete("OwnDelete/{id}")]
        [Authorize]
        public async Task<IActionResult> OwnDelete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            if (user.Id != product.UserId)
            {
                return new JsonResult("Not your product");
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("OwnAdd")]
        [Authorize]
        public async Task<ActionResult<Product>> OwnAdd(Product product)
        {

            var check = _context.Products.Any(e => e.Name == product.Name && e.UserId == null);
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

            var owncheck = _context.Products.Any(e => e.Name == product.Name && e.UserId == user.Id);
            if (owncheck == true)
            {
                ModelState.AddModelError("Name", "Name already in use in your Own Products");
                return BadRequest(ModelState);
            }

            product.UserId = user.Id;
            product.isFav = null;

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);

        }

        [HttpPut("OwnUpdate/{id}")]
        [Authorize]
        public async Task<IActionResult> OwnUpdate(int id, Product product)
        {
            var check = _context.Products.Any(e => e.Name == product.Name && e.ProductId != product.ProductId && e.UserId == null);
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

            var owncheck = _context.Products.Any(e => e.Name == product.Name && e.UserId == user.Id);
            if (owncheck == true)
            {
                ModelState.AddModelError("Name", "Name already in use in your Own Products");
                return BadRequest(ModelState);
            }

            if (user.Id != product.UserId)
            {
                return new JsonResult("Not your product");
            }

            product.UserId = user.Id;
            product.isFav = null;

            if (id != product.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }

        [HttpGet("GetUserProductsByCategory/{name}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Product>>> GetUserProductsByCategory(string name)
        {

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var list = await _context.Products.Where(a => a.UserId == null && a.Category == name).ToListAsync();

            var ownlist = await _context.Products.Where(a => a.UserId == user.Id && a.Category == name).ToListAsync();

            list.AddRange(ownlist);

            var favlist = await _context.UserProductFavs.Where(a => a.UserId == user.Id).ToListAsync();

            foreach (Product prod in list)
            {
                if (favlist.Any(a => a.ProductId == prod.ProductId))
                {
                    prod.isFav = true;
                }
            }

            return list;
        }

        [HttpGet("GetUserOwnProductsByCategory/{name}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Product>>> GetUserOwnProductsByCategory(string name)
        {

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var ownlist = await _context.Products.Where(a => a.UserId == user.Id && a.Category == name).ToListAsync();


            return ownlist;
        }

        [Route("AddFav/{id}")]
        [HttpPost]
        public async Task<ActionResult<List<string>>> AddFav(int id)
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var UserFav = new UserProductFav
            {
                UserId = user.Id,
                ProductId = id
            };

            _context.UserProductFavs.Add(UserFav);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [Route("DeleteFav/{id}")]
        [HttpDelete]
        public async Task<ActionResult<List<string>>> DeleteFav(int id)
        {
            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);
            var userproduct = await _context.UserProductFavs.FirstOrDefaultAsync(a=>a.UserId==user.Id && a.ProductId==id);
            if (userproduct == null)
            {
                return NotFound();
            }

            _context.UserProductFavs.Remove(userproduct);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("GetUserFavProducts")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Product>>> GetUserFavProducts()
        {

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var list = await _context.Products.Where(a => a.UserId == null).ToListAsync();

            var ownlist = await _context.Products.Where(a => a.UserId == user.Id).ToListAsync();

            var favlist = await _context.UserProductFavs.Where(a => a.UserId == user.Id).ToListAsync();

            List<Product> finallist = new List<Product>();

            list.AddRange(ownlist);
            foreach (Product prod in list)
            {
                if (favlist.Any(a => a.ProductId == prod.ProductId))
                {
                    finallist.Add(prod);
                }
            }

            return finallist;
        }

        [HttpGet("GetUserFavProductsByCategory/{name}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Product>>> GetUserFavProductsByCategory(string name)
        {

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var list = await _context.Products.Where(a => a.UserId == null && a.Category == name).ToListAsync();

            var ownlist = await _context.Products.Where(a => a.UserId == user.Id && a.Category == name).ToListAsync();

            list.AddRange(ownlist);

            var favlist = await _context.UserProductFavs.Where(a => a.UserId == user.Id).ToListAsync();

            List<Product> finallist = new List<Product>();

            foreach (Product prod in list)
            {
                if (favlist.Any(a => a.ProductId == prod.ProductId))
                {
                    finallist.Add(prod);
                }
            }

            return finallist;

        }
    }
}
