using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlavaSolutionsFinal.Models
{
    public class Period
    {
        public int PeriodId { get; set; }
        public Nullable<System.DateTime> FiscalyearFromDate { get; set; }
        public Nullable<System.DateTime> FiscalyearToDate { get; set; }
        public string Year { get; set; }
    }
}