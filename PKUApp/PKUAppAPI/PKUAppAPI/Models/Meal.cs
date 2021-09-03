using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }
        public ICollection<MealProduct> MealProducts { get; set; }
        public ICollection<UserMeal> UserMeals { get; set; }
    }
}
