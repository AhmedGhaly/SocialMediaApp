using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.ServiceAbstraction
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
    }
}
