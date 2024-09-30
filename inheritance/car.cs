using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class car
    {
        public static List<car> cars = new List<car>();

        public string model { get; set; }
        public int id { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public int hp { get; set; }
        public string make { get; set; }
        
    }
}
