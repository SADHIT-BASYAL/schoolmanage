using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smsproz.Models
{
    public class TeacherSubject
    {
        public int Id { get; set; } 
        [Required]
        [Display(Name ="CLASS ID")]
        public int claId { get; set; }
        public cla cla { get; set; }   
        public int SubjectId { get; set; }  
          public int TeacherId { get; set; }  
  
    }
}