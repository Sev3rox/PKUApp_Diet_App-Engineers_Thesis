using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class Exercise
    {
        //Calories per 1h and * 100
        public int ExerciseId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Calories is required."), Range(1, 1000 * 100, ErrorMessage = "Please enter a Calories value >= 0 and <= 1000")]
        public int Calories { get; set; }
        public ICollection<UserExercise> UserExercises { get; set; }
    }
}
