using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavaSolutionsFinal.Models
{
    public class MemberAccount
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Account #")]
        public string AccountNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName); 
            }
        }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public virtual ApplicationUser  User { get; set; }

        public string ApplicationUserId { get; set; }

    }
}