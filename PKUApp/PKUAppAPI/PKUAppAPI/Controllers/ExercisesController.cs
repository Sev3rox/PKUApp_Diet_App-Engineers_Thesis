using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PKUAppAPI.Models;
using PKUAppAPI.Data;

namespace PKUAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {

        public class Result<T>
        {
            public int Count { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public List<T> Items { get; set; }
        }

        public class ExerciseParam
        {
            public bool param { get; set; }
            public Exercise Exercise { get; set; }
        }

        public class chartData
        {
            public string name { get; set; }
            public int value { get; set; }
        }

        public class ExerciseTime
        {
            public int Time { get; set; }
            public string UserId { get; set; }

            public int UserExerciseId { get; set; }
            public Exercise Exercise { get; set; }
        }

        private static int pagesize = 10;

        private static int pagesizeplan = 7;

        private readonly PKUAppDbContext _context;

        public ExercisesController(PKUAppDbContext context)
        {
            _context = context;
        }

        // GET: api/Exercises
        [HttpGet]
        public async Task<ActionResult<Result<Exercise>>> GetExercises(string search = null, string sort = null, bool asc = false, int page = 1)
        {

            List<Exercise> list = new List<Exercise>();

            list = await _context.Exercises.Where(a=> EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();


            if (sort != null)
            {
                if (asc == true)
                    list = list.OrderBy(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
                else
                    list = list.OrderByDescending(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
            }

            Result<Exercise> result = new Result<Exercise>
            {
                Count = list.Count(),
                PageIndex = page,
                PageSize = pagesize,
                Items = list.Skip((page - 1) * pagesize).Take((pagesize)).ToList()
            };

            return Ok(result);
        }

        // GET: api/Exercises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exercise>> GetExercise(int id)
        {
            var exercise = await _context.Exercises.FindAsync(id);

            if (exercise == null)
            {
                return NotFound();
            }

            return exercise;
        }

        // PUT: api/Exercises/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PutExercise(int id, Exercise exercise)
        {
            var check = _context.Exercises.Any(e => e.Name == exercise.Name && e.ExerciseId != exercise.ExerciseId);
            if (check == true)
            {
                ModelState.AddModelError("Name", "Name already in use");
                return BadRequest(ModelState);
            }
            else
            {
                if (id != exercise.ExerciseId)
                {
                    return BadRequest();
                }

                _context.Entry(exercise).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExerciseExists(id))
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

        // POST: api/Exercises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<Exercise>> PostExercise(Exercise exercise)
        {
            var check = _context.Exercises.Any(e => e.Name == exercise.Name);
            if (check == true)
            {
                ModelState.AddModelError("Name", "Name already in use");
                return BadRequest(ModelState);
            }
            else
            {
                _context.Exercises.Add(exercise);
                await _context.SaveChangesAsync();

                return CreatedAtAction("PostExercise", new { id = exercise.ExerciseId }, exercise);
            }
        }

        // DELETE: api/Exercise/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteExercise(int id)
        {
            var exercise = await _context.Exercises.FindAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }

            _context.Exercises.Remove(exercise);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExerciseExists(int id)
        {
            return _context.Exercises.Any(e => e.ExerciseId == id);
        }

        [HttpGet("GetUserExercises")]
        [Authorize]
        public async Task<ActionResult<Result<ExerciseParam>>> GetUserDishProducts(DateTime date, string search = null, string sort = null, bool asc = false, int page = 1)
        {

            var claims = User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            List<Exercise> list = new List<Exercise>();
            List<ExerciseParam> finallist = new List<ExerciseParam>();

            list = await _context.Exercises.Where(a => EF.Functions.Like(a.Name, "%" + search + "%")).ToListAsync();


            if (sort != null)
            {
                if (asc == true)
                    list = list.OrderBy(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
                else
                    list = list.OrderByDescending(x => x.GetType().GetProperty(sort).GetValue(x)).ToList();
            }

            var helpdate = new DateTime(date.Year, date.Month, date.Day);

            var ondaylist = _context.UserExercises.Where(a => a.Date == helpdate && a.UserId == user.Id);

            foreach(var exer in list)
            {
                var exerparam = new ExerciseParam
                {
                    param = false,
                    Exercise = exer
                };

                if (ondaylist.Any(a => a.ExerciseId == exer.ExerciseId))
                {
                    exerparam.param = true;
                }

                finallist.Add(exerparam);
            }

            Result<ExerciseParam> result = new Result<ExerciseParam>
            {
                Count = list.Count(),
                PageIndex = page,
                PageSize = pagesize,
                Items = finallist.Skip((page - 1) * pagesize).Take((pagesize)).ToList()
            };

            return Ok(result);
        }

        [HttpPost("AddExerciseToDay")]
        public async Task<IActionResult> AddExerciseToDay(UserExercise userexer)
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            userexer.UserId = user.Id;
            userexer.Date = new DateTime(userexer.Date.Year, userexer.Date.Month, userexer.Date.Day);

            _context.UserExercises.Add(userexer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("EditExerciseToDay")]
        public async Task<IActionResult> EditExerciseToDay(UserExercise userexer)
        {

            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            if (user.Id != userexer.UserId)
            {
                return new JsonResult("Not your exercise in plan");
            }

            userexer.Date = new DateTime(userexer.Date.Year, userexer.Date.Month, userexer.Date.Day);

            _context.Entry(userexer).State = EntityState.Modified;

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

        [HttpDelete("DeleteExerciseToDay")]
        public async Task<IActionResult> DeleteExerciseToDay(DateTime date, int exerid)
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

            var todel =await  _context.UserExercises.FirstOrDefaultAsync(a => a.UserId == user.Id && a.Date == helpdate && a.ExerciseId == exerid);

            if(todel!=null)
            _context.UserExercises.Remove(todel); 

            await _context.SaveChangesAsync();

            return NoContent();

        }

        [HttpGet("GetExerciseInDay")]
        public async Task<ActionResult<Result<ExerciseTime>>> GetExerciseInDay(DateTime date, int page=1)
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


            List<ExerciseTime> list = new List<ExerciseTime>();

            var userexerlist = await _context.UserExercises.Where(a => a.UserId==user.Id && a.Date==helpdate).ToListAsync();

            foreach(var ex in userexerlist)
            {
                var exer = await _context.Exercises.FirstOrDefaultAsync(a => a.ExerciseId == ex.ExerciseId);

                var exertime = new ExerciseTime
                {
                    Exercise = exer,
                    Time = ex.Time,
                    UserId=ex.UserId,
                    UserExerciseId=ex.UserExerciseId
                };

                list.Add(exertime);
            }

            Result<ExerciseTime> result = new Result<ExerciseTime>
            {
                 Count = list.Count(),
                 PageIndex = page,
                 PageSize = pagesizeplan,
                 Items = list.Skip((page - 1) * pagesizeplan).Take((pagesizeplan)).ToList()
            };

                return Ok(result);
        }

        [HttpGet("GetDaySummary")]
        public async Task<ActionResult<Object>> GetDaySummary(DateTime date)
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

            var userexerlist = await _context.UserExercises.Where(a => a.UserId == user.Id && a.Date == helpdate).ToListAsync();

            int time = 0;

            int cal = 0;

            foreach (var ex in userexerlist)
            {
                time +=ex.Time;
                var exercise =await _context.Exercises.FirstOrDefaultAsync(a=>a.ExerciseId==ex.ExerciseId);
                cal += exercise.Calories* ex.Time/60/100;
            }

            var res = new
            {
                Calories = cal,
                Time = time
            };

            return Ok(res);
        }


        [HttpGet("GetCharts")]
        public async Task<ActionResult<IEnumerable<chartData>>> GetCharts(DateTime date, string chartType = "", int chartDays = 0)
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
            firstdate = firstdate.AddDays(-(chartDays - 1));

            if (chartType == "Calories")
            {
                while (firstdate <= lastdate)
                {
                    var exercisesInDay = await _context.UserExercises.Where(a => a.Date == firstdate && a.UserId == user.Id).ToListAsync();

                    var value = 0;

                    foreach (var exer in exercisesInDay)
                    {
                        var oneExer = await _context.Exercises.FirstOrDefaultAsync(a => a.ExerciseId == exer.ExerciseId);
                        value += oneExer.Calories * exer.Time/100/100/60;
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
            else if (chartType == "Time")
            {
                while (firstdate <= lastdate)
                {
                    var exercisesInDay = await _context.UserExercises.Where(a => a.Date == firstdate && a.UserId == user.Id).ToListAsync();

                    var value = 0;

                    foreach (var exer in exercisesInDay)
                    {
                        var oneExer = await _context.Exercises.FirstOrDefaultAsync(a => a.ExerciseId == exer.ExerciseId);
                        value += exer.Time / 100;
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
