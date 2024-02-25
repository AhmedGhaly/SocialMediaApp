using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Repository_interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User getById(string id);
    }
}
