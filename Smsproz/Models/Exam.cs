using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smsproz.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public int ClaId { get; set; }  
         public int SubjectId { get; set; }  
        public Subject Subject { get; set; }

        public string RollNumber { get; set; }  
        public string TotalMarks { get; set; }  
        public string OutofMarks { get; set; }
    }
}