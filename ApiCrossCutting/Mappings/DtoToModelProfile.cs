using ApiDomain.Dtos.User;
using ApiDomain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();
        }
    }
}
