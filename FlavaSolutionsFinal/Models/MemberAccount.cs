using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FlavaSolutionsFinal.Models
{
    public class MemberAccount
    {
        [Key]
        public int MemberID { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "MobilePhone")]
        public string MobilePhone { get; set; }


        [NotMapped]
        public ICollection<Transaction> transactions { get; set; }

        [NotMapped]
        public ICollection<Balance> balances { get; set; }

        public string Name

        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }

        }


    }
}
    

