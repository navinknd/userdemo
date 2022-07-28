using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Core.ViewModels
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string MobileNumber { get; set; }

        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
