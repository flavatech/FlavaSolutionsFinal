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
        [Key]
        public int TransactionId { get; set; }

        [Display(Name = "Select Member")]

        public int? MemberID { get; set; }
        public MemberAccount memberAccount { get; set; }

        [Display(Name = "Select Plan")]

        public int? PlanID { get; set; }
        public Plan Plan { get; set; }

        [Display(Name = "Select Activity")]

        public int? ActivityID { get; set; }
        public Activity Activity { get; set; }


        [Display(Name = "Period")]
        public int? PeriodID { get; set; }
        public Period PeriodName { get; set; }

        [Display(Name = "Payment Type")]
        public int? PaymentTypeID { get; set; }
        public PaymentType PaymentType { get; set; }

        [Display(Name = "Payment From Date")]
        [DataType(DataType.Date)]
        public DateTime? PaymentFromdt { get; set; }

        [Display(Name = "Payment To Date")]
        [DataType(DataType.Date)]
        public DateTime? PaymentTodt { get; set; }


        [Display(Name = "Amount Due")]

        public decimal? AmountDue { get; set; }

        public int? TaxID { get; set; }
        public Taxes SalesTax { get; set; }

        [Display(Name = "Amount Paid")]

        public decimal? AmountPaid { get; set; }


        [Display(Name = "Balance")]

        public decimal? Balance { get; set; }

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




    }
}