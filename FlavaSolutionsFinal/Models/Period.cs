using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using DataType = System.ComponentModel.DataAnnotations.DataType;

namespace FlavaSolutionsFinal.Models
{
    public class Period
    {
        public int PeriodId { get; set; }

        public string PeriodName { get; set; }

        [Display(Name = "Fiscal Year From Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FiscalyearFromDate { get; set; }

        [Display(Name = "Fiscal Year To Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FiscalyearToDate { get; set; }


        [NotMapped]
        public ICollection<Plan> Plans { get; set; }

        [NotMapped]
       public ICollection<Transaction> Transactions { get; set; }
    }
}