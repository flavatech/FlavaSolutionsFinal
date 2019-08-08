using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlavaSolutionsFinal.Models
{
    public class ActivityMaster
    {
        [Key]
        public int ActivityID { get; set; }
        [Required(ErrorMessage = "Please enter Scheme Name")]
        [Remote("SchemeNameExists", "Scheme", ErrorMessage = "Scheme Name Already Exists ")]
        public string ActivityName { get; set; }
        public string Createdby { get; set; }
        public DateTime Createddate { get; set; }
    }
}