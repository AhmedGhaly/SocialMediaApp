using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class User : IdentityUser
    {

        public User()
        {
            posts = new List<Post>();
            comments = new List<Comment>();
            likes = new List<Like>();
            subComments = new List<SubComment>();
        }

        //public string id { get; set; }
        public string? image { get; set; }
        public string? coverImage { get; set; }



        [ForeignKey("address")]
        public int addressId { get; set; }
        public virtual Address? address { get; set; }








        public virtual IEnumerable<Post> posts { get; set; }
        public virtual IEnumerable<Like> likes { get; set; }
        public virtual IEnumerable<Comment> comments { get; set; }
        public virtual IEnumerable<SubComment> subComments { get; set; }





    }
}
