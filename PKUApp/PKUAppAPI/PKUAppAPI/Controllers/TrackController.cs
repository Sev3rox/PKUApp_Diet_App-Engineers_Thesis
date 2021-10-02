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

        public class message
        {
            public string msg { get; set; }
            public int type { get; set; }
        }

        public string[] Messages = new string[]
        {
            "You are gaining weight",
            "You are losing weight",
            "Your weight is stable",
            "Your Phe results are getting worse be careful!",
            "Your Phe results are getting better keep it up!",
            "You Phe results are stable"
        };

        private readonly PKUAppDbContext _context;
        public TrackController(PKUAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<chartData>>> GetTracking(int type, DateTime date)
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

            var helpdate = new DateTime(date.Year, date.Month, date.Day);
            helpdate = helpdate.AddDays(-30);

            var firstRecord = await _context.TrackedValues.Where(a => a.UserId == user.Id && a.Type==type && a.Date>=helpdate).OrderBy(a => a.Date).Take(1).ToListAsync();

            var lastRecord = await _context.TrackedValues.Where(a => a.UserId == user.Id && a.Type == type && a.Date >= helpdate).OrderByDescending(a => a.Date).Take(1).ToListAsync();

            var lastdate = new DateTime();
            var firstdate = new DateTime();
            if (lastRecord.Count == 1)
                lastdate = new DateTime(lastRecord[0].Date.Year, lastRecord[0].Date.Month, lastRecord[0].Date.Day);
            if (firstRecord.Count == 1)
                firstdate = new DateTime(firstRecord[0].Date.Year, firstRecord[0].Date.Month, firstRecord[0].Date.Day);

            if (lastdate != new DateTime() && firstdate != new DateTime())
            {
                while (firstdate <= lastdate)
                {
                    var trackRecord = await _context.TrackedValues.FirstOrDefaultAsync(a => a.UserId == user.Id && a.Type == type && a.Date == firstdate);

                    if (trackRecord != null)
                    {
                        var chartDay = new chartData
                        {
                            name = firstdate.ToString("d", CultureInfo.CreateSpecificCulture("en-US")),
                            value = (double)((double)trackRecord.Value / 100)
                        };
                        result.Add(chartDay);
                    }
                    else
                    {
                        var chartDay = new chartData
                        {
                            name = firstdate.ToString("d", CultureInfo.CreateSpecificCulture("en-US")),
                            value = 0
                        };
                        result.Add(chartDay);
                    }

                    firstdate = firstdate.AddDays(1);
                }
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

        [HttpGet("GetMessage")]
        public async Task<ActionResult<message>> GetMessage(DateTime date, int type = 0)
        {
            var claims = User.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();
            if (claims.Count() == 0)
            {
                return new JsonResult(null);
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == claims[0].Value);

            var trackRecords = await _context.TrackedValues.Where(a => a.UserId == user.Id && a.Type == type).OrderByDescending(a => a.Date).Take(2).ToListAsync();

            trackRecords = trackRecords.OrderBy(a => a.Date).ToList();

            if (trackRecords.Count < 2)
                return null;

            if (type == 1) {
                if(trackRecords[1].Value >= trackRecords[0].Value+100)
                {
                    var message = new message
                    {
                        msg = Messages[0],
                        type = 1
                    };
                    return message;
                }
                else if(trackRecords[0].Value >= trackRecords[1].Value+100)
                {
                    var message = new message
                    {
                        msg = Messages[1],
                        type = 1
                    };
                    return message;
                }
                else
                {
                    var message = new message
                    {
                        msg = Messages[2],
                        type = 1
                    };
                    return message;
                }
            }
            else if(type == 2) {
                if(trackRecords[1].Value >= trackRecords[0].Value + 50)
                {
                    var message = new message
                    {
                        msg = Messages[3],
                        type = 2
                    };
                    return message;
                }
                else if(trackRecords[0].Value >= trackRecords[1].Value + 50)
                {
                    var message = new message
                    {
                        msg = Messages[4],
                        type = 3
                    };
                    return message;
                }
                else
                {
                    var message = new message
                    {
                        msg = Messages[5],
                        type = 1
                    };
                    return message;
                }
            }
                return null;
        }
    }
}
