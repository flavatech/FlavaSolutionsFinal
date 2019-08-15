using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavaSolutionsFinal.Models
{
    public class Trainer
    {

        public int id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Required]
        [Display(Name = "Telephone Number")]
        public String Contact { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Years of Experience")]
        public String YearsOfExperience { get; set; }

        [Required]
        [Display(Name = "Speciality")]
        public String Speciality { get; set; }
        public string Name

        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }
    }
}

    
