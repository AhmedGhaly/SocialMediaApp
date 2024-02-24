using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Comment
    {

        public Comment()
        {
            likes = new List<Like>();
            subComments = new List<SubComment>();
        }

        public int Id { get; set; }

        [ForeignKey("CommentContent")]
        public int commenContentId { get; set; }
        public virtual CommentContent CommentContent { get; set; }


        [ForeignKey("User")]
        public int userId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Post")]
        public int postId { get; set; }
        public virtual Post Post { get; set; }


        public virtual IEnumerable<Like> likes { get; set; }
        public virtual IEnumerable<SubComment> subComments { get; set; }

    }
}
