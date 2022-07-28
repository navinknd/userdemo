using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserManagement.Core.Entities
{
    public class User
    {
        public int ID { get; set; }

     
        public string MobileNumber { get; set; }

  
        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        public DateTime CreatedDate { get; set; }

       
        public string Email { get; set; }



    }
}
