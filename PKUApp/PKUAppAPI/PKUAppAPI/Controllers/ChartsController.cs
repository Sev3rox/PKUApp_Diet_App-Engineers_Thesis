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
            var firstdate = new DateTime(date.Year, date.Month, date.Day);
            firstdate=firstdate.AddDays(-(chartDays-1));

            var meds = await _context.UserMedicines.Where(a => a.StartDate != a.EndDate && a.StartDate<= lastdate && (a.EndDate>= firstdate || a.EndDate==null) && a.UserId == user.Id).OrderBy(a=>a.StartDate).ToListAsync();

            var medhelp = 0;

            if (chartType == "Phe")
            {
                while (firstdate <= lastdate)
                {
                    var mealsInDay = await _context.Meals.Where(a=>a.Date == firstdate && a.UserId==user.Id).ToListAsync();

                    List<MealProduct> mproducts = new List<MealProduct>();

                    foreach (var meal in mealsInDay)
                    {
                        var onemeal = await _context.MealProducts.Where(a => a.MealId == meal.MealId).ToListAsync();
                        mproducts.AddRange(onemeal);
                    }

                    var value = 0;

                    for (int i = medhelp; i < meds.Count(); i++)
                    {
                        if (firstdate >= meds[i].StartDate && (firstdate < meds[i].EndDate || meds[i].EndDate==null))
                        {
                            value += meds[i].Phe / 100;
                            medhelp = i;
                            break;
                        }
                    }

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

                    for (int i = medhelp; i < meds.Count(); i++)
                    {
                        if (firstdate >= meds[i].StartDate && (firstdate < meds[i].EndDate || meds[i].EndDate == null))
                        {
                            value += meds[i].Calories / 100;
                            medhelp = i;
                            break;
                        }
                    }

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

                    for (int i = medhelp; i < meds.Count(); i++)
                    {
                        if (firstdate >= meds[i].StartDate && (firstdate < meds[i].EndDate || meds[i].EndDate == null))
                        {
                            value += meds[i].Protein / 100;
                            medhelp = i;
                            break;
                        }
                    }

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

                    for (int i = medhelp; i < meds.Count(); i++)
                    {
                        if (firstdate >= meds[i].StartDate && (firstdate < meds[i].EndDate || meds[i].EndDate == null))
                        {
                            value += meds[i].Fat / 100;
                            medhelp = i;
                            break;
                        }
                    }

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

                    for (int i = medhelp; i < meds.Count(); i++)
                    {
                        if (firstdate >= meds[i].StartDate && (firstdate < meds[i].EndDate || meds[i].EndDate == null))
                        {
                            value += meds[i].Carb / 100;
                            medhelp = i;
                            break;
                        }
                    }

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
