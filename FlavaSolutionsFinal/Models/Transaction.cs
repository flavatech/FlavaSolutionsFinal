using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlavaSolutionsFinal.Models
{
    public class Transaction
    {
        public int id { get; set; }
        public Nullable<int> PlanID { get; set; }
        public Nullable<int> ActivityID { get; set; }
        public string PaymentType { get; set; }
        public Nullable<System.DateTime> PaymentFromdt { get; set; }
        public Nullable<System.DateTime> PaymentTodt { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public Nullable<System.DateTime> NextRenwalDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<long> UserID { get; set; }
     
    }
}