using Domain_Layer.Models;
using Domain_Layer.Repository_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Repository
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly SocialMediaContext context;
        public UserRepository(SocialMediaContext context) : base(context)
        {
            this.context = context;
        }

        public User getById(string id)
        {
            return context.Users.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
