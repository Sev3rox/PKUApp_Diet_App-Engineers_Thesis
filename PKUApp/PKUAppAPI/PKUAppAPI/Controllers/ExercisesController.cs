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
    public class ExercisesController : ControllerBase
    {

        public class Result<T>
        {
            public int Count { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public List<T> Items { get; set; }
        }

        private static int pagesize = 10;

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
            List<Exercise> finallist = new List<Exercise>();

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
    }
}
