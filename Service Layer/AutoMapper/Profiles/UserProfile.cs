using AutoMapper;
using Domain_Layer.Models;
using DTO.RequestDto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User,
                RequestUserDto>().ReverseMap();
        }

    }
}
