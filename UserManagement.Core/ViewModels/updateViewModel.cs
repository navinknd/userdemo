using System.ComponentModel.DataAnnotations;

namespace UserManagement.Core.ViewModels
{
    public class updateViewModel
    {
        [Required]
        public int ID { get; set; }


        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }

    }
}
