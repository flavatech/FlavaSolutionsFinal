using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlavaSolutionsFinal.Models
{
    public class Plan
    {
        [Key]
        public int PlanID { get; set; }
        [Remote("PlannameExists", "Plan", ErrorMessage = "Plan Name Already Exists ")]
        [Required(ErrorMessage = "Enter Plan Name")]
        public string PlanName { get; set; }
        [Required(ErrorMessage = "Enter Plan Fee")]
        public Double? PlanAmount { get; set; }
        [Required(ErrorMessage = "Enter Servicetax Amout")]
         public int CreateBy { get; set; }
        public int ModifiedBy { get; set; }
        public string RecStatus { get; set; }
        [Display(Name = "Activity")]
        
        public int? ActivityID { get; set; }

        [Display(Name = "Period")]
        public int? PeriodID { get; set; }

        public int? TotalAmout { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        [NotMapped]
        public IEnumerable<Activity> ListScheme { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> ListofPeriod { get; set; }

    }
}