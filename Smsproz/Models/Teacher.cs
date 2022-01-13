using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smsproz.Models
{
    public class Teacher
    {
        
        public int TeacherId { get; set; } 
        [Required]
        [Display(Name ="Teacher Name")]
        public string TeacherName { get; set; }
        [Display(Name = "Date Of Birth")]

        public string DOB { get; set; }
 
        public string Gender { get; set; }
 
        public string Mobile { get; set; }
 
        public string Email { get; set; }
 
        public string Address { get; set; } 
    }
}