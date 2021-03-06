using System;
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
    [Authorize]
    public class MealsController : ControllerBase
    {

        public class Result<T>
        {
            public int Count { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public List<T> Items { get; set; }
        }
        public class ProductMeal
        {
            public int Weight { get; set; }
            public Product Product { get; set; }
        }

        public string[] MealsNames = new string[]
        {
            "First Meal",
            "Second Meal",
            "Third Meal",
            "Fourth Meal",
            "Fifth Meal",
            "Sixth Meal",
            "Seventh Meal",
            "Eighth Meal",
            "Ninth Meal",
            "Tenth Meal"
        };

        private static int pagesize = 8;

        private readonly PKUAppDbContext _context;

        public MealsController(PKUAppDbContext context)
        {
            _context = context;
        }

        // GET: api/Meals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meal>>> GetMeals(DateTime date)
        {
            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);
            var helpdate = new DateTime(date.Year, date.Month, date.Day);

            return await _context.Meals.Where(a => a.UserId == user.Id && a.Date == helpdate).ToListAsync();
        }

        // GET: api/Meals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meal>> GetMeal(int id)
        {
            var meal = await _context.Meals.FindAsync(id);

            if (meal == null)
            {
                return NotFound();
            }

            return meal;
        }

        // PUT: api/Meals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeal(int id, Meal meal)
        {
            if (id != meal.MealId)
            {
                return BadRequest();
            }

            _context.Entry(meal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MealExists(id))
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

        // POST: api/Meals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Meal>> PostMeal(DateTime date)
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var Meals = _context.Meals.Where(a => a.UserId == user.Id && a.Date == date).ToList();

            var count = Meals.Count();

            if (count >= 10)
            {
                ModelState.AddModelError("Count", "You can have maximally 10 Meals for day");
                return BadRequest(ModelState);
            }

            var meal = new Meal
            {
                Name = MealsNames[count],
                Date = date,
                UserId = user.Id
            };

            _context.Meals.Add(meal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostMeal", new { id = meal.MealId }, meal);
        }

        // DELETE: api/Meals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeal(int id)
        {
            var meal = await _context.Meals.FindAsync(id);
            if (meal == null)
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

            var Meals = _context.Meals.Where(a => a.UserId == user.Id && a.Date == meal.Date).ToList();
            var count = 0;
            var position = 0;

            foreach (var m in Meals)
            {
                if (m == meal)
                {
                    position = 1;
                }
                if (position == 1)
                {
                    if (count > 0)
                    {
                        m.Name = MealsNames[count - 1];
                        _context.Entry(m).State = EntityState.Modified;
                        try
                        {
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            if (!MealExists(id))
                            {
                                return NotFound();
                            }
                            else
                            {
                                throw;
                            }
                        }
                    }
                }
                count++;
            }

            _context.Meals.Remove(meal);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpPost("AddProductToMeal")]
        public async Task<IActionResult> AddProductToMeal(MealProduct mealpro)
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            _context.MealProducts.Add(mealpro);
            await _context.SaveChangesAsync();


            var userLast = new UserProductLastAdded
            {
                UserId = user.Id,
                ProductId = mealpro.ProductId
            };

            if (await _context.UserProductLastAddeds.AnyAsync(a => a.ProductId == userLast.ProductId && a.UserId == userLast.UserId))
            {
                var userlastdel = await _context.UserProductLastAddeds.FirstOrDefaultAsync(a => a.ProductId == userLast.ProductId && a.UserId == userLast.UserId);
                _context.UserProductLastAddeds.Remove(userlastdel);
                await _context.SaveChangesAsync();

                var neworder = 0;
                if (await _context.UserProductLastAddeds.CountAsync() > 0)
                    neworder = await _context.UserProductLastAddeds.MaxAsync(a => a.Order);

                userLast.Order = neworder + 1;
                _context.UserProductLastAddeds.Add(userLast);
                await _context.SaveChangesAsync();
            }
            else
            {
                var neworder = 0;
                if (await _context.UserProductLastAddeds.CountAsync() > 0)
                    neworder = await _context.UserProductLastAddeds.MaxAsync(a => a.Order);

                userLast.Order = neworder + 1;
                _context.UserProductLastAddeds.Add(userLast);
                await _context.SaveChangesAsync();
            }

            return NoContent();

        }

        [HttpPut("EditProductToMeal")]
        public async Task<IActionResult> EditProductToMeal(MealProduct mealpro)
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            _context.Entry(mealpro).State = EntityState.Modified;

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

        [HttpGet("GetMealProducts")]
        public async Task<ActionResult<Result<ProductMeal>>> GetMealProducts(int id, int page = 1)
        {
            List<ProductMeal> mealproducts = new List<ProductMeal>();

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var mproducts = await _context.MealProducts.Where(a => a.MealId == id).ToListAsync();

            foreach (var mealprod in mproducts)
            {
                var prod = await _context.Products.FindAsync(mealprod.ProductId);
                var temp = new ProductMeal
                {
                    Product = prod,
                    Weight = mealprod.Weight
                };
                mealproducts.Add(temp);
            }

            Result<ProductMeal> result = new Result<ProductMeal>
            {
                Count = mealproducts.Count(),
                PageIndex = page,
                PageSize = pagesize,
                Items = mealproducts.Skip((page - 1) * pagesize).Take((pagesize)).ToList()
            };

            return result;

        }

        [HttpDelete("DeleteMealProducts")]
        public async Task<ActionResult<ProductMeal>> DeleteMealProducts(int mealid, int productid)
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var mealpro = await _context.MealProducts.FirstOrDefaultAsync(a => a.MealId == mealid && a.ProductId == productid);
            _context.MealProducts.Remove(mealpro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MealExists(int id)
        {
            return _context.Meals.Any(e => e.MealId == id);
        }

        [HttpGet("GetMealSummary/{id}")]
        public async Task<ActionResult<ProductMeal>> GetMealSumarry(int id)
        {
            List<ProductMeal> mealproducts = new List<ProductMeal>();

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var mproducts = await _context.MealProducts.Where(a => a.MealId == id).ToListAsync();

            var summary = new ProductMeal
            {
                Product = new Product(),
                Weight = 0
            };

            foreach (var mealprod in mproducts)
            {
                var prod = await _context.Products.FindAsync(mealprod.ProductId);
                summary.Product.Phe += (int)((prod.Phe / 100 * mealprod.Weight / 100));
                summary.Product.Calories += (int)((prod.Calories / 100 * mealprod.Weight / 100));
                summary.Product.Protein += (int)((prod.Protein / 100 * mealprod.Weight / 100));
                summary.Product.Fat += (int)((prod.Fat / 100 * mealprod.Weight / 100));
                summary.Product.Carb += (int)((prod.Carb / 100 * mealprod.Weight / 100));
                summary.Weight += mealprod.Weight;
            }

            return summary;

        }

        [HttpGet("GetDaySummary")]
        public async Task<ActionResult<ProductMeal>> GetDaySummary(DateTime date)
        {
            List<ProductMeal> mealproducts = new List<ProductMeal>();
            List<MealProduct> mproducts = new List<MealProduct>();

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var helpdate = new DateTime(date.Year, date.Month, date.Day);
            var meals = await _context.Meals.Where(a => a.Date == helpdate && a.UserId == user.Id).ToListAsync();



            foreach (var meal in meals)
            {
                var onemeal = await _context.MealProducts.Where(a => a.MealId == meal.MealId).ToListAsync();
                mproducts.AddRange(onemeal);
            }

            var summary = new ProductMeal
            {
                Product = new Product(),
                Weight = 0
            };

            foreach (var mealprod in mproducts)
            {
                var prod = await _context.Products.FindAsync(mealprod.ProductId);
                summary.Product.Phe += (int)((prod.Phe / 100 * mealprod.Weight / 100));
                summary.Product.Calories += (int)((prod.Calories / 100 * mealprod.Weight / 100));
                summary.Product.Protein += (int)((prod.Protein / 100 * mealprod.Weight / 100));
                summary.Product.Fat += (int)((prod.Fat / 100 * mealprod.Weight / 100));
                summary.Product.Carb += (int)((prod.Carb / 100 * mealprod.Weight / 100));
                summary.Weight += mealprod.Weight;
            }

            return summary;

        }

        [HttpGet("GetOffAlerts")]
        public async Task<ActionResult<bool>> GetOffAlerts(DateTime date)
        {
            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);
            var helpdate = new DateTime(date.Year, date.Month, date.Day);

            return await _context.UserOffAlerts.AnyAsync(a => a.UserId == user.Id && a.Date == helpdate);
        }

        [HttpPost("AddOffAlerts")]
        public async Task<IActionResult> AddOffAlerts(DateTime date)
        {
            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);
            var helpdate = new DateTime(date.Year, date.Month, date.Day);

            var alertOff = new UserOffAlert
            {
                UserId = user.Id,
                Date = helpdate
            };

            _context.UserOffAlerts.Add(alertOff);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("GetDayMedicine")]
        public async Task<ActionResult<UserMedicine>> GetDayMedicine(DateTime date)
        {
            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var helpdate = new DateTime(date.Year, date.Month, date.Day);

            var meds = await _context.UserMedicines.FirstOrDefaultAsync(a => a.StartDate != a.EndDate && a.StartDate <= helpdate && (a.EndDate > helpdate || a.EndDate==null) && a.UserId == user.Id);

            return meds;
        }
    }
}
