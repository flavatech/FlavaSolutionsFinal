using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace FlavaSolutionsFinal.Models
{
    public class PaymentType
    {
        public int PaymentTypeID { get; set; }
        [Display(Name = "Payment Name")]
        [Required(ErrorMessage = "Please enter Payment Name")]

        public string PaymentName { get; set; }

        [Display(Name = "Created By")]
        public string Createdby { get; set; }

        [Display(Name = "Created Date")]

        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Last Modified By")]
        public string ModifiedBy { get; set; }

        [Display(Name = "Last Modified Date")]
        public DateTime? ModifiedDate { get; set; }

        [NotMapped]
        public ICollection<Transaction> Transactions { get; set; }

        [NotMapped]
        public ICollection<Balance> Balances { get; set; }

    }
}
