using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smsproz.Models
{
    public class Student
    {
        [Display(Name ="Student Id")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name ="Student Name")]

        public string StudentName { get; set;}
        [Required]
        [Display(Name ="Date of Birth")]

        public DateTime DOB { get; set;}
        [Required]
        [Display(Name ="Gender")]

        public string Gender { get; set;}
        [Required]
        [Display(Name ="Mobile")]

        public string Mobile { get; set;}
        [Required]
        [Display(Name ="Roll Number")]


        public string RollNumber { get; set;}
        [Required]

        [Display(Name ="Address")]

        public string Address { get; set;}
        [Display(Name ="Class Id")]


        public int claId { get; set;}
        [Display(Name ="Class")]

        public cla cla { get; set;}
    }
}