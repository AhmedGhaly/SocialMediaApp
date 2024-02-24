using AutoMapper;
using Domain_Layer;
using Domain_Layer.Models;
using Domain_Layer.Repository_interfaces;
using DTO.RequestDto.User;
using Service_Layer.ServiceAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Service
{
    internal class UserSerivce : IUserService
    {
        private readonly IUnitOfWork unitOfWork;

        public UserSerivce(IUnitOfWork unitOfWork, IMapper mappper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mappper;
        }

        public IMapper mapper { get; }

        public IEnumerable<RequestUserDto> getAllUsers()
        {
            var users = unitOfWork.Users.GetAll();   
            return mapper.Map<List<RequestUserDto>>(users);

        }

        public RequestUserDto getById(int id)
        {
            var user = unitOfWork.Users.GetById(id);
            return mapper.Map<RequestUserDto>(user);
        }
    }
}
