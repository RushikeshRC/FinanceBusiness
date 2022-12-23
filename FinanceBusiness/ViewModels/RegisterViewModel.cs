using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinanceBusiness.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        //[MaxLength(10, ErrorMessage = "Your message must be of 10 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Confirm password dose not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Address { get; set; }

        public string SelectedRole { get; set; }
    }
}