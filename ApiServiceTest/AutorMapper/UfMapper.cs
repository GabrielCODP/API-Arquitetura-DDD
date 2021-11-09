using ApiDomain.Dtos.Uf;
using ApiDomain.Entities;
using ApiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ApiServiceTest.AutorMapper
{
    public class UfMapper : BaseTesteService
    {
        [Fact(DisplayName = "É Possível Mapear os Modelos de UF")]

        public void E_Possivel_Mapear_Os_Modelos_Uf()
        {
            var model = new UfModel
            {
                Id = Guid.NewGuid(),
                Nome = Faker.Address.UsState(),
                Sigla = Faker.Address.UsState().Substring(1, 3),
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            var listaEntity = new List<UfEntity>();

            for (int i = 0; i < 5; i++)
            {
                var item = new UfEntity
                {
                    Id = Guid.NewGuid(),
                    Nome = Faker.Address.UsState(),
                    Sigla = Faker.Address.UsState().Substring(1, 3),
                    CreateAt = DateTime.UtcNow,
                    UpdateAt = DateTime.UtcNow
                };
                listaEntity.Add(item);
            }

            //Model => Entity
            var entity = Mapper.Map<UfEntity>(model);
            Assert.Equal(entity.Id, model.Id);
            Assert.Equal(entity.Nome, model.Nome);
            Assert.Equal(entity.Sigla,model.Sigla);
            Assert.Equal(entity.CreateAt, model.CreateAt);
            Assert.Equal(entity.UpdateAt, model.UpdateAt);

            //Entity para Dto
            var userDto = Mapper.Map<UfDto>(entity);
            Assert.Equal(userDto.Id, entity.Id);
            Assert.Equal(userDto.Nome, entity.Nome);
            Assert.Equal(userDto.Sigla, entity.Sigla);

            var ListaDto = Mapper.Map<List<UfDto>>(listaEntity);
            Assert.True(ListaDto.Count() == listaEntity.Count());

            for (int i = 0; i < ListaDto.Count(); i++)
            {
                Assert.Equal(ListaDto[i].Id, listaEntity[i].Id);
                Assert.Equal(ListaDto[i].Nome, listaEntity[i].Nome);
                Assert.Equal(ListaDto[i].Sigla, listaEntity[i].Sigla);
            }

            //Dto para Model
            var userModel = Mapper.Map<UfDto>(model);
            Assert.Equal(userModel.Id, model.Id);
            Assert.Equal(userModel.Nome, model.Nome);
            Assert.Equal(userModel.Sigla, model.Sigla);

        }
    }
}
