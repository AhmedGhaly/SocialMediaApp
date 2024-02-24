using AutoMapper;
using Domain_Layer;
using Service_Layer.ServiceAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Service
{
    public class ServiceManager : IServiceManager
    {
        public IUserService UserService { get; private set; }


        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UserService = new UserSerivce(unitOfWork, mapper) ;
        }
    }
}
