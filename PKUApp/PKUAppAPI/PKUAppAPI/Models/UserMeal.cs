using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class UserMeal
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
