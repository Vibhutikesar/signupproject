using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using UserRegistrationProject.Utilities;
using Xunit;
using Xunit.Sdk;

namespace UserReg.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(10, MinimumLength = 3)]
        [Required(ErrorMessage = "Please Enter Username..")]
        [Display(Name = "UserName")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Please Enter Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$", ErrorMessage = "Password must contain atleast 8 characters and must have 1 alphabet and 1 number")]
        public string Pwd { get; set; }
         
        [Required(ErrorMessage = "Please Enter the Confirm Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Pwd")]
        public string Confirmpwd { get; set; }

        [Required(ErrorMessage = "Please Enter Email...")]
        [Display(Name = "Email")]
      // [ValidEmailDomain(allowedDomain:"bcstechnology.com.au",
         //  ErrorMessage ="Email domain must  be  bcstechnology.com.au" )]
        [RegularExpression("^[a-z A-Z 0-9_/-/.]+[@][a-z]+[/ .][a-z]{2,3}$",  ErrorMessage = "Please enter a valid mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Select the Gender...")] 
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Select the Marital Status...")]
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }


    }
}