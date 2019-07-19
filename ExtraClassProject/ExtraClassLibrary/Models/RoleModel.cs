using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraClassLibrary.Models
{
    public class RoleModel
    {
        public int Id;
        public string RoleName { get; set; }
        public List<UserModel> Users { get; set; } = new List<UserModel>();
    }
}
