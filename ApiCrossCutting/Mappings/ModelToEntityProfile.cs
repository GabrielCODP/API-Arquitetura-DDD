using ApiDomain.Entities;
using ApiDomain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            //CreateMap<UserEntity, UserModel>().ReverseMap();
            CreateMap<UserModel, UserEntity>().ReverseMap();

            CreateMap<UfModel, UfEntity>().ReverseMap();

            CreateMap<MunicipioModel, MunicipioEntity>().ReverseMap();

            CreateMap<CepModel, CepEntity>().ReverseMap();
        }
    }
}
