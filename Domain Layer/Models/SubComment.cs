using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class SubComment
    {

        public SubComment()
        {
            likes = new List<Like>();
        }


        public int id { get; set; }

        [ForeignKey("Comment")]
        public int commentId { get; set; }
        public virtual Comment Comment { get; set; }


        [ForeignKey("CommentContent")]
        public int commentContentId { get; set; }
        public virtual CommentContent CommentContent { get; set; }


        [ForeignKey("User")]
        public string userId { get; set; }
        public virtual User User { get; set; }


        public virtual IEnumerable<Like> likes { get; set; }

    }
}
