using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class UserExercise
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Time is required."), Range(1, 10000 * 100, ErrorMessage = "Please enter a Time >= 1 minute and <= 10000 minutes")]
        public int Time { get; set; }
    }
}
