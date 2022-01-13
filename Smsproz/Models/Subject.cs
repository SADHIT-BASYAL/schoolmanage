using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Smsproz.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
 
        public int ClaId { get; set; }
        public cla cla { get; set; }    
         public string SubjectName { get; set; }

    }
}