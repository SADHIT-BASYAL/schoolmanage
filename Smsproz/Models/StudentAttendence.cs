using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smsproz.Models
{
    public class StudentAttendence
    {
        public int Id { get; set; } 
        public int ClaId { get; set; }  
        public int SubjectId { get; set; }
        public string RollNumber { get; set; } 
        public bool Status { get; set; }    
        public DateTime DateTime { get; set; }
    }

}