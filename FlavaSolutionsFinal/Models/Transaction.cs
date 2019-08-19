using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlavaSolutionsFinal.Models
{
    public class Transaction
    {
        public int id { get; set; }

        [Display(Name = "Plan")]

        public Nullable<int> PlanID { get; set; }

        [Display(Name = "Activity")]
   
        public Nullable<int> ActivityID { get; set; }

        [Display(Name = "Payment Type")]
    
        public string PaymentType { get; set; }

        [Display(Name = "Payment From Date")]
        [DataType(DataType.Date)]
        public DateTime? PaymentFromdt { get; set; }

        [Display(Name = "Payment To Date")]
        [DataType(DataType.Date)]
        public DateTime? PaymentTodt { get; set; }

        [Display(Name = "Amount Paid")]
    
        public Nullable<decimal> PaymentAmount { get; set; }

        [Display(Name = "Expiry Date")]
        [DataType(DataType.Date)]
        public DateTime? NextRenwalDate { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Last Modified Date")]
        [DataType(DataType.Date)]
        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }
        public Nullable<long> UserID { get; set; }
     
    }
}