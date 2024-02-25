using Domain_Layer;
using Domain_Layer.Models;
using Domain_Layer.Repository_interfaces;
using Infrastructure_Layer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer
{
    public class UnitOfWork : IUnitOfWork

    {
        private readonly SocialMediaContext _context;

        public UnitOfWork(SocialMediaContext context)
        {
            Users = new UserRepository(context);
            _context = context;
        }

        //public IBaseRepository<User> Users { get; private set; }

        public IUserRepository Users { get; private set; }

        public int complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
