using Domain_Layer.Models;
using Domain_Layer.Repository_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public interface IUnitOfWork :IDisposable
    {
        IBaseRepository<User> Users { get; }    
        int complete();
    }
}
