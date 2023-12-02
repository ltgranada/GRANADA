using System.ComponentModel.DataAnnotations;
namespace GranadaITELEC1C.ViewModels
{
    ﻿public class RegisterViewModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "a username is required")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "a password is required")]
        public string? Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "you must confirm your password")]
        public string? ConfirmPassword { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "email address required!")]
        public string? Email { get; set; }

        
        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }
    }
}
