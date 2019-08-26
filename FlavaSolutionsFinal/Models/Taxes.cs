using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlavaSolutionsFinal.Models
{
    public class Taxes
    {
        [Key]
        public int TaxID { get; set; }
        public string TaxName { get; set; }
        public double SalesTax { get; set; }

       [NotMapped]
       public ICollection<Transaction> Transactions { get; set; }


       
    }
}