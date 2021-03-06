using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class MealProduct
    {
        public int MealId { get; set; }
        public Meal Meal { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required(ErrorMessage = "Weight is required."), Range(1, 10000 * 100, ErrorMessage = "Please enter a Weight >= 1g and <= 10000g")]
        public int Weight { get; set; }
    }
}
