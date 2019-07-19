using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraClassLibrary.Models
{
    public class ClassModel
    {
        public int Id;
        public string ClassName { get; set; }
        public UserModel Teacher { get; set; }

        public string Description { get; set; }
        public List<UserModel> Students { get; set; }
    }
}
