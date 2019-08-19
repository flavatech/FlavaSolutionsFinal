using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlavaSolutionsFinal.Models
{
    public class Activity
    {
     
        public int ActivityID { get; set; }
        [Display(Name = "Activity")]
        [Required(ErrorMessage = "Please enter Activity Name")]
       
        public string ActivityName { get; set; }

        [Display(Name = "Created By")]
        public string Createdby { get; set; }

        [Display(Name = "Created Date")]

        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Last Modified By")]
        public string ModifiedBy { get; set; }

        [Display(Name = "Last Modified Date")]
        public DateTime? ModifiedDate { get; set; }
    }
}