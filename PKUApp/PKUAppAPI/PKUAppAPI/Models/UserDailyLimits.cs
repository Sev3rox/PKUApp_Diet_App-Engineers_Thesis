using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class UserDailyLimits
    {
        public int UserDailyLimitsId { get; set; }
        [Required(ErrorMessage = "PheLimit is required."), Range(0, 100 * 100 * 1000, ErrorMessage = "Please enter a PheLimit value >= 0 and <= 100000")]
        public int PheLimit { get; set; }
        [Required(ErrorMessage = "CaloriesLimit is required."), Range(0, 100 * 100 * 1000, ErrorMessage = "Please enter a CaloriesLimit value >= 0 and <= 100000")]
        public int CaloriesLimit { get; set; }
        [Required(ErrorMessage = "ProteinLimit is required."), Range(0, 100 * 100 * 100, ErrorMessage = "Please enter a ProteinLimit value >= 0 and <= 10000")]
        public int ProteinLimit { get; set; }
        [Required(ErrorMessage = "FatLimit is required."), Range(0, 100 * 100 * 100, ErrorMessage = "Please enter a FatLimit value >= 0 and <= 10000")]
        public int FatLimit { get; set; }
        [Required(ErrorMessage = "CarbLimit is required."), Range(0, 100 * 100 * 100, ErrorMessage = "Please enter a CarbLimit value >= 0 and <= 10000")]
        public int CarbLimit { get; set; }
        public bool AddCalories { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
