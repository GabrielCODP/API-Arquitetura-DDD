using ApiDomain.Dtos.Cep;
using ApiDomain.Dtos.Municipio;
using ApiDomain.Dtos.Uf;
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
            #region User
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();
            #endregion

            CreateMap<UfModel, UfDto>().ReverseMap();

            #region Municipio
            CreateMap<MunicipioModel, MunicipioDto>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoCreate>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoUpdate>().ReverseMap();
            #endregion

            CreateMap<CepModel, CepDto>().ReverseMap();
            CreateMap<CepModel, CepDtoCreate>().ReverseMap();
            CreateMap<CepModel, CepDtoUptade>().ReverseMap();
        }
    }
}
