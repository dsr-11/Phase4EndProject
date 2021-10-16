using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhaseProject4.Models
{
    public class Pizza
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public string desc { get; set; }
        public string crust { get; set; }
        public double price { get; set; }
        public string image_url { get; set; }
    }
}
