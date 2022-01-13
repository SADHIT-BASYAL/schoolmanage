using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smsproz.Models
{
    public class TeacherAttendence
    {
        public int id { get; set; } 
        public int TeacherId { get; set; }  
        public Teacher Teacher { get; set; }
        public bool Status { get; set; }    
        public DateTime GetDateTime { get; set; }  
    }
}