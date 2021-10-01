using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    [Index(nameof(Type))]
    public class TrackedValue
    {
        public int TrackedValueId { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; } // 1-weight, 2-phe
        [Required(ErrorMessage = "Value is required."), Range(0, 1000 * 100, ErrorMessage = "Please enter a Value value >= 1 and <= 1000")]
        public int Value { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
