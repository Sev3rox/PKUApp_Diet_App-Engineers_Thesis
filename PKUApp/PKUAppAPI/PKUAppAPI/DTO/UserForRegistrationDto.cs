using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Whole implementation of .NET Identity and JWT is inspired by the one that is pressented in https://docs.microsoft.com/en-us/documentation/
//So Code that is used in this app that implements identity might be similar to other applications bacause it is almostly the same in all apps using it

namespace PKUAppAPI.DTO
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
