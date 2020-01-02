using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAccessTutorial.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage ="You need to give us your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "You need to give us your last name.")]
        public string LastName { get; set; }

        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You need to give us your email address.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm email adress")]
        [Compare("EmailAddress", ErrorMessage = "The Email and Confirm Email must match.")]
        public string  ConfirmEmail { get; set; }

        [Required(ErrorMessage = "You must have a password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "You need to provide long enough password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirm password do not match.")]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }

    }
}