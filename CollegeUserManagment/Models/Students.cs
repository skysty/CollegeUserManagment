using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeUserManagment.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronomyc { get; set; }
        public string BirthYear { get; set; }
    }
}
