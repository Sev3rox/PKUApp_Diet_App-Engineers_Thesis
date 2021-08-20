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
        //These values are for Product per 100 grams and the value should be divided by 100 to get the correct one(because it's easier to store integer instead of fraction)
        [Required(ErrorMessage = "Phe is required."), Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger or equal 0")]
        public int Phe { get; set; }
        [Required(ErrorMessage = "Calories is required."), Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger or equal to 0")]
        public int Calories { get; set; }
        [Required(ErrorMessage = "Protein is required."), Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger or equal to 0")]
        public int Protein { get; set; }
        [Required(ErrorMessage = "TotalFat is required."), Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger or equal to 0")]
        public int TotalFat { get; set; }
        [Required(ErrorMessage = "TotalCarb is required."), Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger or equal to 0")]
        public int TotalCarb { get; set; }

    }
}
