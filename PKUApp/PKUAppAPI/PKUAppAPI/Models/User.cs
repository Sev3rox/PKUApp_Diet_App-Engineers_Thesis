using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<UserProductFav> UserProductFavs { get; set; }
        public ICollection<Meal> Meals { get; set; }
        public ICollection<UserProductLastAdded> UserProductLastAddeds { get; set; }
        public ICollection<UserProductDish> UserProductDish { get; set; }
        public UserDailyLimits DailyLimits { get; set; }
        public ICollection<UserOffAlert> UserOffAlerts { get; set; }

    }

    public class AppErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateUserName(string userName)
        {
            var error = base.DuplicateUserName(userName);
            error.Description = "This email is already taken.";
            return error;
        }
    }
}
