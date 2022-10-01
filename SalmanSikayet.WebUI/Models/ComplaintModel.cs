using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalmanSikayet.WebUI.Models
{
    public class ComplaintModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
