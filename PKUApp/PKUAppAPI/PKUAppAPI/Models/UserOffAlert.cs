using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class UserOffAlert
    {
        public int UserOffAlertId { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
