using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class PostContnet
    {
        public int id { get; set; }

        public string postContent { get; set; }
        public string? image { get; set; }




    }
}
