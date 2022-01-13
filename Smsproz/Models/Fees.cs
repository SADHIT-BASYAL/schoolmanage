using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smsproz.Models
{
    public class Fees
    {
        public int FeesId { get; set; }
        public int ClaId { get; set; }  
        public cla cla { get; set; }
        [Required]
        [Display(Name ="Fees Amount")]
        public string FeesAmount { get; set; }  
    }
}