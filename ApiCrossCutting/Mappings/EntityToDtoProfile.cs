using ApiDomain.Dtos.Cep;
using ApiDomain.Dtos.Municipio;
using ApiDomain.Dtos.Uf;
using ApiDomain.Dtos.User;
using ApiDomain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>().ReverseMap();

            CreateMap<UserDtoCreateResult, UserEntity>().ReverseMap();

            CreateMap<UserDtoUpdateResult, UserEntity>().ReverseMap();

            CreateMap<UfDto, UfEntity>().ReverseMap();

            CreateMap<MunicipioDto, MunicipioEntity>().ReverseMap();

            CreateMap<MunicipioDtoCompleto, MunicipioEntity>().ReverseMap();
            //verificar erro
            CreateMap<MunicipioDtoCreateResult, MunicipioEntity>().ReverseMap();

            CreateMap<MunicipioDtoUpdateResult, MunicipioEntity>().ReverseMap();


            CreateMap<CepDto, CepEntity>().ReverseMap();

            CreateMap<CepDtoCreateResult, CepEntity>().ReverseMap();

            CreateMap<CepDtoUpdateResult, CepEntity>().ReverseMap();

        }
    }
}
