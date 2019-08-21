using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
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
      
        public int PlanID { get; set; }

        [Required(ErrorMessage = "Enter Plan Name")]
        [Display(Name = "Plan Name")]
        public string PlanName { get; set; }

        [Required(ErrorMessage = "Plan Amount")]
        [Display(Name = "Plan Amount")]
        public Double? PlanAmount { get; set; }

       [Display(Name = "Activity")]
        public int? ActivityID { get; set; }
        public Activity Activity { get; set; }

        [Display(Name = "Period")]
        public int? PeriodID { get; set; }
        public Period Period { get; set; }


        [Display(Name = "Total")]
        public int? TotalAmout { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Created By")]
        public string Createdby { get; set; }

        [Display(Name = "Last Modified By")]
        public string ModifiedBy { get; set; }

        [Display(Name = "Last Modified Date")]
        [DataType(DataType.Date)]
        public DateTime? ModifiedDate { get; set; }

        [NotMapped]
        public ICollection<Transaction> Transactions { get; set; }



    }
}