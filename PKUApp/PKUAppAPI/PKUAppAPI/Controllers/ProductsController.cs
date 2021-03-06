using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PKUAppAPI.Models;
using PKUAppAPI.Data;

namespace PKUAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        public class Result<T>
        {
            public int Count { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public List<T> Items { get; set; }
        }

        public class ProductParam
        {
            public bool param { get; set; }
            public Product Product { get; set; }
        }

        public string[] Categories = new string[]
        {
                "Fruits",
                "Vegetables",
                "Dairy",
                "Grains",
                "Protein Foods",
                "Drinks",
                "Snacks",
                "Dishes",
                "Other"
        };

        private static int pagesize = 10;
        private static int mealpagesize = 8;
        private readonly PKUAppDbContext _context;

        public ProductsController(PKUAppDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<Result<Product>>> GetProducts(string search = null, string sort = null, bool asc = false, string cat = null, int page=1)
        {

            List<Product> list = new List<Product>();
            List<Product> finallist = new List<Product>();

            if (cat == null)
            {
                list = await _context.Products.Where(a => a.UserId == null && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();
            }
            else
            {
                list = await _context.Products.Where(a => a.UserId == null && a.Category == cat && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();
            }

            if (sort != null)
            {
                if (asc == true)
                    list = list.OrderBy(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
                else
                    list = list.OrderByDescending(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
            }

            Result<Product> result = new Result<Product>
            {
                Count = list.Count(),
                PageIndex = page,
                PageSize = pagesize,
                Items = list.Skip((page - 1) * pagesize).Take((pagesize)).ToList()
            };

            return Ok(result);
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

                return CreatedAtAction("PostProduct", new { id = product.ProductId }, product);
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

        [HttpGet("GetAllCategories")]
        public async Task<ActionResult<List<string>>> GetAllCategories()
        {
            var categories = Categories.ToList();

            return categories;
        }

        [HttpGet("GetUserProducts")]
        [Authorize]
        public async Task<ActionResult<Result<ProductParam>>> GetUserProducts(string search=null, string sort=null, bool asc=false, string cat=null, int page=1, bool last=false)
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
            List<Product> templist = new List<Product>();
            List<Product> ownlist = new List<Product>();
            List<UserProductFav> favlist = new List<UserProductFav>();
            List<UserProductLastAdded> lastlist = new List<UserProductLastAdded>();
            List<Product> finallist = new List<Product>();
            List<ProductParam> prodparamlist = new List<ProductParam>();

            int helpcat = 0;
            if (cat == "Fav")
            {
                cat = null;
                helpcat = 1;
            }

            if (cat == null)
            {
                list = await _context.Products.Where(a => a.UserId == null && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

                ownlist = await _context.Products.Where(a => a.UserId == user.Id && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

            }
            else 
            {
                list = await _context.Products.Where(a => a.UserId == null && a.Category == cat && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

                ownlist = await _context.Products.Where(a => a.UserId == user.Id && a.Category == cat && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();
            }

            favlist = await _context.UserProductFavs.Where(a => a.UserId == user.Id).ToListAsync();

            list.AddRange(ownlist);

            if (sort != null)
            {
               if(asc==true)
                    list = list.OrderBy(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
                else
                    list = list.OrderByDescending(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
            }

            if (helpcat != 1)
            {
            }
            else
            {
                foreach (Product prod in list)
                {

                    if (favlist.Any(a => a.ProductId == prod.ProductId))
                    {
                        finallist.Add(prod);
                    }
                }
                list = finallist;
            }

            lastlist = await _context.UserProductLastAddeds.Where(a => a.UserId == user.Id).ToListAsync();

            if (last == false)
            {
            }
            else
            {
                if (sort == null)
                {

                    lastlist=lastlist.OrderByDescending(x => x.Order).ToList();

                    foreach (UserProductLastAdded lastprod in lastlist)
                    {

                        if (list.Any(a => a.ProductId == lastprod.ProductId))
                        {
                            templist.Add(list.Find(a => a.ProductId == lastprod.ProductId));
                        }
                    }
                    list = templist;
                }
                else
                {
                    foreach (Product prod in list)
                    {

                        if (lastlist.Any(a => a.ProductId == prod.ProductId))
                        {
                            templist.Add(prod);
                        }
                    }
                    list = templist;
                }
            }

            foreach (Product prod in list)
            {
                var prodparam = new ProductParam
                {
                    param = false,
                    Product = prod

                };

                if (favlist.Any(a => a.ProductId == prod.ProductId))
                {
                    prodparam.param = true;
                }

                prodparamlist.Add(prodparam);
            }   

            Result<ProductParam> result = new Result<ProductParam>
            {
                Count = prodparamlist.Count(),
                PageIndex = page,
                PageSize = pagesize,
                Items = prodparamlist.Skip((page - 1) * pagesize).Take((pagesize)).ToList()
            };

            return result;
        }

        [HttpGet("GetUserOwnProducts")]
        [Authorize]
        public async Task<ActionResult<Result<Product>>> GetUserOwnProducts(string search = null, string sort = null, bool asc = false, string cat = null, int page=1, bool last=false)
        {

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            List<Product> ownlist = new List<Product>();
            List<UserProductFav> favlist = new List<UserProductFav>();
            List<Product> finallist = new List<Product>();
            List<Product> templist = new List<Product>();
            List<UserProductLastAdded> lastlist = new List<UserProductLastAdded>();

            int helpcat = 0;
            if (cat == "Fav")
            {
                cat = null;
                helpcat = 1;
            }

            if (cat == null)
            {
                ownlist = await _context.Products.Where(a => a.UserId == user.Id && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();
            }
            else
            {
                ownlist = await _context.Products.Where(a => a.UserId == user.Id && a.Category == cat && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();
            }

            favlist = await _context.UserProductFavs.Where(a => a.UserId == user.Id).ToListAsync();

            if (sort != null)
            {
                if (asc == true)
                    ownlist = ownlist.OrderBy(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
                else
                    ownlist = ownlist.OrderByDescending(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
            }

            if (helpcat != 1)
            {
            }
            else
            {
                foreach (Product prod in ownlist)
                {

                    if (favlist.Any(a => a.ProductId == prod.ProductId))
                    {
                        finallist.Add(prod);
                    }
                }
                ownlist = finallist;
            }

            lastlist = await _context.UserProductLastAddeds.Where(a => a.UserId == user.Id).ToListAsync();

            if (last == false)
            {
            }
            else
            {
                if (sort == null)
                {

                    lastlist=lastlist.OrderByDescending(x => x.Order).ToList();

                    foreach (UserProductLastAdded lastprod in lastlist)
                    {

                        if (ownlist.Any(a => a.ProductId == lastprod.ProductId))
                        {
                            templist.Add(ownlist.Find(a => a.ProductId == lastprod.ProductId));
                        }
                    }
                    ownlist = templist;
                }
                else
                {
                    foreach (Product prod in ownlist)
                    {

                        if (lastlist.Any(a => a.ProductId == prod.ProductId))
                        {
                            templist.Add(prod);
                        }
                    }
                    ownlist = templist;
                }
            }

            Result<Product> result = new Result<Product>
            {
                Count = ownlist.Count(),
                PageIndex = page,
                PageSize = pagesize,
                Items = ownlist.Skip((page - 1) * pagesize).Take((pagesize)).ToList()
            };

            return result;
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

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("OwnAdd", new { id = product.ProductId }, product);

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

            var owncheck = _context.Products.Any(e => e.Name == product.Name && e.UserId == user.Id && e.ProductId != product.ProductId);
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

        [Route("AddFav/{id}")]
        [HttpPost]
        [Authorize]
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
        [Authorize]
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

        [HttpGet("GetUserMealProducts")]
        [Authorize]
        public async Task<ActionResult<Result<ProductParam>>> GetUserMealProducts(string search = null, string sort = null, bool asc = false, string cat = null, int page = 1, int id=0, bool last=false)
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
            List<MealProduct> onmeallist = new List<MealProduct>();
            List<Product> finallist = new List<Product>();
            List<ProductParam> prodparamlist = new List<ProductParam>();
            List<Product> templist = new List<Product>();
            List<UserProductLastAdded> lastlist = new List<UserProductLastAdded>();

            int helpcat = 0;
            if (cat == "Fav")
            {
                cat = null;
                helpcat = 1;
            }

            if (cat == null)
            {
                list = await _context.Products.Where(a => a.UserId == null && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

                ownlist = await _context.Products.Where(a => a.UserId == user.Id && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

            }
            else
            {
                list = await _context.Products.Where(a => a.UserId == null && a.Category == cat && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

                ownlist = await _context.Products.Where(a => a.UserId == user.Id && a.Category == cat && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();
            }

            favlist = await _context.UserProductFavs.Where(a => a.UserId == user.Id).ToListAsync();

            onmeallist = await _context.MealProducts.Where(a => a.MealId == id).ToListAsync();

            list.AddRange(ownlist);

            if (sort != null)
            {
                if (asc == true)
                    list = list.OrderBy(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
                else
                    list = list.OrderByDescending(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
            }

            if (helpcat != 1)
            {
            }
            else
            {
                foreach (Product prod in list)
                {

                    if (favlist.Any(a => a.ProductId == prod.ProductId))
                    {
                        finallist.Add(prod);
                    }
                }
                list = finallist;
            }

            lastlist = await _context.UserProductLastAddeds.Where(a => a.UserId == user.Id).ToListAsync();

            if (last == false)
            {
            }
            else
            {
                if (sort == null)
                {

                    lastlist=lastlist.OrderByDescending(x => x.Order).ToList();

                    foreach (UserProductLastAdded lastprod in lastlist)
                    {

                        if (list.Any(a => a.ProductId == lastprod.ProductId))
                        {
                            templist.Add(list.Find(a => a.ProductId == lastprod.ProductId));
                        }
                    }
                    list = templist;
                }
                else
                {
                    foreach (Product prod in list)
                    {

                        if (lastlist.Any(a => a.ProductId == prod.ProductId))
                        {
                            templist.Add(prod);
                        }
                    }
                    list = templist;
                }
            }


            if (id != 0)
            {
                foreach (var mprod in list)
                {
                    var prodparam = new ProductParam
                    {
                        param = false,
                        Product = mprod

                    };

                    if (onmeallist.Any(a => a.ProductId == mprod.ProductId))
                    {
                        prodparam.param = true;
                    }

                    prodparamlist.Add(prodparam);
                }
            }

            Result<ProductParam> result = new Result<ProductParam>
            {
                Count = prodparamlist.Count(),
                PageIndex = page,
                PageSize = mealpagesize,
                Items = prodparamlist.Skip((page - 1) * mealpagesize).Take((mealpagesize)).ToList()
            };

            return result;
        }


        [HttpGet("GetUserDishProducts")]
        [Authorize]
        public async Task<ActionResult<Result<ProductParam>>> GetUserDishProducts(string search = null, string sort = null, bool asc = false, string cat = null, int page = 1, bool last = false)
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
            List<UserProductDish> ondishlist = new List<UserProductDish>();
            List<Product> finallist = new List<Product>();
            List<ProductParam> prodparamlist = new List<ProductParam>();
            List<Product> templist = new List<Product>();
            List<UserProductLastAdded> lastlist = new List<UserProductLastAdded>();

            int helpcat = 0;
            if (cat == "Fav")
            {
                cat = null;
                helpcat = 1;
            }

            if (cat == null)
            {
                list = await _context.Products.Where(a => a.UserId == null && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

                ownlist = await _context.Products.Where(a => a.UserId == user.Id && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

            }
            else
            {
                list = await _context.Products.Where(a => a.UserId == null && a.Category == cat && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();

                ownlist = await _context.Products.Where(a => a.UserId == user.Id && a.Category == cat && EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();
            }

            favlist = await _context.UserProductFavs.Where(a => a.UserId == user.Id).ToListAsync();

            ondishlist = await _context.UserProductDish.Where(a=>a.UserId== user.Id).ToListAsync();

            list.AddRange(ownlist);

            if (sort != null)
            {
                if (asc == true)
                    list = list.OrderBy(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
                else
                    list = list.OrderByDescending(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
            }

            if (helpcat != 1)
            {
            }
            else
            {
                foreach (Product prod in list)
                {

                    if (favlist.Any(a => a.ProductId == prod.ProductId))
                    {
                        finallist.Add(prod);
                    }
                }
                list = finallist;
            }

            lastlist = await _context.UserProductLastAddeds.Where(a => a.UserId == user.Id).ToListAsync();

            if (last == false)
            {
            }
            else
            {
                if (sort == null)
                {

                    lastlist=lastlist.OrderByDescending(x => x.Order).ToList();

                    foreach (UserProductLastAdded lastprod in lastlist)
                    {

                        if (list.Any(a => a.ProductId == lastprod.ProductId))
                        {
                            templist.Add(list.Find(a => a.ProductId == lastprod.ProductId));
                        }
                    }
                    list = templist;
                }
                else
                {
                    foreach (Product prod in list)
                    {

                        if (lastlist.Any(a => a.ProductId == prod.ProductId))
                        {
                            templist.Add(prod);
                        }
                    }
                    list = templist;
                }
            }


                foreach (var dprod in list)
                {
                    var prodparam = new ProductParam
                    {
                        param = false,
                        Product = dprod

                    };

                    if (ondishlist.Any(a => a.ProductId == dprod.ProductId))
                    {
                        prodparam.param = true;
                    }

                    prodparamlist.Add(prodparam);
                }

            Result<ProductParam> result = new Result<ProductParam>
            {
                Count = prodparamlist.Count(),
                PageIndex = page,
                PageSize = mealpagesize,
                Items = prodparamlist.Skip((page - 1) * mealpagesize).Take((mealpagesize)).ToList()
            };

            return result;
        }


    }
}
