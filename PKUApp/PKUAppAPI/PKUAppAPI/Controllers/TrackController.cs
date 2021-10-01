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
    public class TrackController : ControllerBase //Name is Track instead of Tracking because my adblock extension was blocking api call with Tracking name
    {
        public class chartData
        {
            public string name { get; set; }
            public double value { get; set; }
        }

        private readonly PKUAppDbContext _context;
        public TrackController(PKUAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<chartData>>> GetTracking(int type)
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

            var trackRecords = await _context.TrackedValues.Where(a => a.UserId == user.Id && a.Type==type).OrderBy(a => a.Date).Take(30).ToListAsync();

            foreach(var trackrecord in trackRecords)
            {
                var chartDay = new chartData
                {
                    name = trackrecord.Date.ToString("d", CultureInfo.CreateSpecificCulture("en-US")),
                    value = (double)((double)trackrecord.Value / 100)
                };
                result.Add(chartDay);
            }

            return result;
        }

        [HttpGet("GetCurrentRecord")]
        public async Task<ActionResult<TrackedValue>> GetCurrentRecord(DateTime date, int type=0)
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

            var result = await _context.TrackedValues.FirstOrDefaultAsync(a => a.UserId == user.Id && a.Type == type && a.Date==helpdate);

            return result;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<chartData>>> PostTracking(TrackedValue value)
        {
            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            value.UserId = user.Id;
            value.Date =  new DateTime(value.Date.Year, value.Date.Month, value.Date.Day);

            _context.TrackedValues.Add(value);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<chartData>>> PutTracking(int id, int value)
        {
            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var trackedRecord = _context.TrackedValues.Find(id);

            if (user.Id != trackedRecord.UserId)
            {
                return new JsonResult("Not your Tracking Record");
            }

            trackedRecord.Value = value;

            _context.Entry(trackedRecord).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
