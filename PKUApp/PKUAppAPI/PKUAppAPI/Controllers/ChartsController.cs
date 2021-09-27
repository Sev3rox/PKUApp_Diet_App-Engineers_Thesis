using System;
using System.Collections.Generic;
using System.Globalization;
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
    [Authorize]
    public class ChartsController : ControllerBase
    {
        public class chartData
        {
           public string name { get; set; }
           public int value { get; set; }
        }

        private readonly PKUAppDbContext _context;
        public ChartsController(PKUAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<chartData>>> GetCharts(DateTime date, string chartType="", int chartDays=0)
        { 
            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var result = new List<chartData>();

            var lastdate = new DateTime(date.Year, date.Month, date.Day);
            lastdate=lastdate.AddDays(-1);
            var firstdate = new DateTime(date.Year, date.Month, date.Day);
            firstdate=firstdate.AddDays(-chartDays);

            var dateString = lastdate.ToString("d", CultureInfo.CreateSpecificCulture("en-US"));

            if (chartType == "Phe")
            {
                while(firstdate <= lastdate)
                {
                    var mealsInDay = await _context.Meals.Where(a=>a.Date == firstdate && a.UserId==user.Id).ToListAsync();

                    List<MealProduct> mproducts = new List<MealProduct>();

                    foreach (var meal in mealsInDay)
                    {
                        var onemeal = await _context.MealProducts.Where(a => a.MealId == meal.MealId).ToListAsync();
                        mproducts.AddRange(onemeal);
                    }

                    var value = 0;

                    foreach (var mealprod in mproducts)
                    {
                        var prod = await _context.Products.FindAsync(mealprod.ProductId);
                        value += (int)((prod.Phe / 100 * mealprod.Weight / 100)/100);
                    }

                    var chartDay = new chartData
                    {
                        name= firstdate.ToString("d", CultureInfo.CreateSpecificCulture("en-US")),
                        value = value
                    };

                    result.Add(chartDay);

                    firstdate=firstdate.AddDays(1);
                }
            }
            else if (chartType == "Calories")
            {
                while (firstdate <= lastdate)
                {
                    var mealsInDay = await _context.Meals.Where(a => a.Date == firstdate && a.UserId == user.Id).ToListAsync();

                    List<MealProduct> mproducts = new List<MealProduct>();

                    foreach (var meal in mealsInDay)
                    {
                        var onemeal = await _context.MealProducts.Where(a => a.MealId == meal.MealId).ToListAsync();
                        mproducts.AddRange(onemeal);
                    }

                    var value = 0;

                    foreach (var mealprod in mproducts)
                    {
                        var prod = await _context.Products.FindAsync(mealprod.ProductId);
                        value += (int)((prod.Calories / 100 * mealprod.Weight / 100) / 100);
                    }

                    var chartDay = new chartData
                    {
                        name = firstdate.ToString("d", CultureInfo.CreateSpecificCulture("en-US")),
                        value = value
                    };

                    result.Add(chartDay);

                    firstdate = firstdate.AddDays(1);
                }
            }
            else if (chartType == "Protein")
            {
                while (firstdate <= lastdate)
                {
                    var mealsInDay = await _context.Meals.Where(a => a.Date == firstdate && a.UserId == user.Id).ToListAsync();

                    List<MealProduct> mproducts = new List<MealProduct>();

                    foreach (var meal in mealsInDay)
                    {
                        var onemeal = await _context.MealProducts.Where(a => a.MealId == meal.MealId).ToListAsync();
                        mproducts.AddRange(onemeal);
                    }

                    var value = 0;

                    foreach (var mealprod in mproducts)
                    {
                        var prod = await _context.Products.FindAsync(mealprod.ProductId);
                        value += (int)((prod.Protein / 100 * mealprod.Weight / 100) / 100);
                    }

                    var chartDay = new chartData
                    {
                        name = firstdate.ToString("d", CultureInfo.CreateSpecificCulture("en-US")),
                        value = value
                    };

                    result.Add(chartDay);

                    firstdate = firstdate.AddDays(1);
                }
            }
            else if (chartType == "Fat")
            {
                while (firstdate <= lastdate)
                {
                    var mealsInDay = await _context.Meals.Where(a => a.Date == firstdate && a.UserId == user.Id).ToListAsync();

                    List<MealProduct> mproducts = new List<MealProduct>();

                    foreach (var meal in mealsInDay)
                    {
                        var onemeal = await _context.MealProducts.Where(a => a.MealId == meal.MealId).ToListAsync();
                        mproducts.AddRange(onemeal);
                    }

                    var value = 0;

                    foreach (var mealprod in mproducts)
                    {
                        var prod = await _context.Products.FindAsync(mealprod.ProductId);
                        value += (int)((prod.Fat / 100 * mealprod.Weight / 100) / 100);
                    }

                    var chartDay = new chartData
                    {
                        name = firstdate.ToString("d", CultureInfo.CreateSpecificCulture("en-US")),
                        value = value
                    };

                    result.Add(chartDay);

                    firstdate = firstdate.AddDays(1);
                }
            }
            else if (chartType == "Carb")
            {
                while (firstdate <= lastdate)
                {
                    var mealsInDay = await _context.Meals.Where(a => a.Date == firstdate && a.UserId == user.Id).ToListAsync();

                    List<MealProduct> mproducts = new List<MealProduct>();

                    foreach (var meal in mealsInDay)
                    {
                        var onemeal = await _context.MealProducts.Where(a => a.MealId == meal.MealId).ToListAsync();
                        mproducts.AddRange(onemeal);
                    }

                    var value = 0;

                    foreach (var mealprod in mproducts)
                    {
                        var prod = await _context.Products.FindAsync(mealprod.ProductId);
                        value += (int)((prod.Carb / 100 * mealprod.Weight / 100) / 100);
                    }

                    var chartDay = new chartData
                    {
                        name = firstdate.ToString("d", CultureInfo.CreateSpecificCulture("en-US")),
                        value = value
                    };

                    result.Add(chartDay);

                    firstdate = firstdate.AddDays(1);
                }
            }

            return result;
        }
    }
}
