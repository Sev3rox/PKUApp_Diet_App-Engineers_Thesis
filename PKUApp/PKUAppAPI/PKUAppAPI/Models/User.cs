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
