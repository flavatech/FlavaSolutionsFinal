using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlavaSolutionsFinal.Models
{
    public class Transactions
    {
        public long PaymentID { get; set; }
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
        public string RecStatus { get; set; }
        public Nullable<long> CustomerID { get; set; }
        public string CustomerNo { get; set; }
    }
}