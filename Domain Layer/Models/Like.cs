using Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Like
    {
        public int id { get; set; }
        public LikeType name { get; set; }

        [ForeignKey("User")]
        public int userId { get; set; }
        public virtual User? User { get; set; }


        [ForeignKey("Post")]
        public int postId { get; set; }
        public virtual Post? Post { get; set; }


        [ForeignKey("SubComment")]
        public int subCommentId { get; set; }
        public virtual SubComment? SubComment { get; set; }


        [ForeignKey("Comment")]
        public int commentId { get; set; }
        public virtual Comment? Comment { get; set; }
    }
}
