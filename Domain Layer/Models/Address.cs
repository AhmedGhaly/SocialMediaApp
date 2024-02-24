using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Address
    {
        public int id { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
    }
}
