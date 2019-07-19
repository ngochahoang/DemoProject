using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraClassLibrary.Models
{
    public class ScoreModel
    {
        public int Id;
        public ClassModel Class { get; set; }
        public UserModel Student { get; set; }
        public double score;
    }
}
