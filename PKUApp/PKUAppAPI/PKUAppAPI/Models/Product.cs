using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }
        //These values are for Product per 100 grams and the value should be divided by 100 to get the correct one(because it's easier to store integer instead of fraction)
        [Required(ErrorMessage = "Phe is required."), Range(0, 1000 * 100, ErrorMessage = "Please enter a Phe value >= 0 and <= 100")]
        public int Phe { get; set; }
        [Required(ErrorMessage = "Calories is required."), Range(0, 1000 * 100, ErrorMessage = "Please enter a Calories value >= 0 and <= 1000")]
        public int Calories { get; set; }
        [Required(ErrorMessage = "Protein is required."), Range(0, 100 * 100, ErrorMessage = "Please enter a Protein value >= 0 and <= 100")]
        public int Protein { get; set; }
        [Required(ErrorMessage = "Fat is required."), Range(0, 100 * 100, ErrorMessage = "Please enter a Fat value >= 0 and <= 100")]
        public int Fat { get; set; }
        [Required(ErrorMessage = "Carb is required."), Range(0, 100 * 100, ErrorMessage = "Please enter a Carb value >= 0 and <= 100")]
        public int Carb { get; set; }

        //Navigation properties
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<UserProductFav> UserProductFavs { get; set; }
        public ICollection<MealProduct> MealProducts { get; set; }
        public ICollection<UserProductLastAdded> UserProductLastAddeds { get; set; }
        public ICollection<UserProductDish> UserProductDish { get; set; }

    }
}
