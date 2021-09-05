using System;
using System.Collections.Generic;
using System.Linq;
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
    public class MealsController : ControllerBase
    {

        public string[] MealsNames = new string[]
        {
            "First Meal",
            "Second Meal",
            "Third Meal",
            "Fourth Meal",
            "Fifth Meal",
            "Sixth Meal",
            "Seventh Meal",
            "Eight Meal",
            "Nineth Meal",
            "Tenth Meal"
        };

        private readonly PKUAppDbContext _context;

        public MealsController(PKUAppDbContext context)
        {
            _context = context;
        }

        // GET: api/Meals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meal>>> GetMeals(DateTime date)
        { 
                var helpdate = new DateTime(date.Year, date.Month, date.Day);
                return await _context.Meals.Where(a => a.Date == helpdate).ToListAsync();
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

            var Meals = _context.Meals.
                Join(
                _context.UserMeals,
                a => a.MealId,
                b => b.MealId,
                (a, b) => new
                {
                    MealId = a.MealId,
                    UserId = b.UserId,
                    Date = a.Date
                }).Where(a => a.UserId == user.Id && a.Date == date).ToList();

            var count = Meals.Count();

            if (count>=10)
            {
                ModelState.AddModelError("Count", "You can have maximally 10 Meals for day");
                return BadRequest(ModelState);
            }

            var meal = new Meal
            {
                Name = MealsNames[count],
                Date = date
            };
            _context.Meals.Add(meal);
            await _context.SaveChangesAsync();

            var usermeal = new UserMeal
            {
                UserId=user.Id,
                MealId=meal.MealId
            };
            _context.UserMeals.Add(usermeal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeal", new { id = meal.MealId }, meal);
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

            _context.Meals.Remove(meal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MealExists(int id)
        {
            return _context.Meals.Any(e => e.MealId == id);
        }
    }
}
