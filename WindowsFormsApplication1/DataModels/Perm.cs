using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
   public class Perm
    {
        public Perm()
        {
            Algorithms = new List<Algorithm>();
        }
        
        public string Title { get; set; }
        public string ProTip { get; set; }
        public string ImgPath { get; set; }

        public List<Algorithm> Algorithms { get; set; }
    }
}
