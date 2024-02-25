using Domain_Layer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer
{
    public class SocialMediaContext : IdentityDbContext<User>
    {
        public SocialMediaContext()
        {

        }

        public SocialMediaContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentContent> CommentContents { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostContnet> PostContnets { get; set; }
        public virtual DbSet<SubComment> SubComments { get; set; }
        public virtual DbSet<User> Users { get; set; }




    }
}
