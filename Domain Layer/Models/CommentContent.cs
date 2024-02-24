using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class CommentContent
    {
        public int id { get; set; }
        public sbyte? iamge { get; set; }
        public string comment { get; set; }
    }
}
