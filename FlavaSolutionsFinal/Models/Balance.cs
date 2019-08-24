using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;

namespace FlavaSolutionsFinal.Models
{
    public class Balance:IdentityUser

        {
        [Key]
        public int BalanceID { get; set; }

        public int? MemberID { get; set; }
        public MemberAccount memberAccount { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? CreatedDate { get; set; }

        public int? PaymentTypeID { get; set; }
        public PaymentType PaymentType { get; set; }

        public int? PlanID { get; set; }
        public Plan planamount { get; set; }

        public int TransactionID { get; set; }
        public Transaction PaymentAmount { get; set; }

        public int TaxID { get; set; }
        public Taxes salestax { get; set; }

        public decimal MBalance { get; set; }

    }
}