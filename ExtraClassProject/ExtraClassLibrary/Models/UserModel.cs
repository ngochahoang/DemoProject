using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraClassLibrary.Models
{
    public class UserModel
    {
        public UserModel(string userName, string password, string email, string address)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Address = address;
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        
    }
}
