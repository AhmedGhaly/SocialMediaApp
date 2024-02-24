using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Post
    {

        public Post()
        {
            likes = new List<Like>();
            comments = new List<Comment>();
        }


        public int id { get; set; }


        [ForeignKey("PostContnet")]
        public int postContentId { get; set; }
        public virtual PostContnet PostContnet { get; set; }


         [ForeignKey("User")]
        public int userId { get; set; }
        public virtual User User { get; set; }

        public virtual IEnumerable<Like> likes { get; set; }
        public virtual IEnumerable<Comment> comments { get; set; }


    }
}
