using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserManagement.Core.ViewModels
{
    public class RegisterViewModel
    {

        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNumber { get; set; }

        [ Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
