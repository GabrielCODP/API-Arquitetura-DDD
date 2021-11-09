using ApiData.Context;
using ApiData.Implementations;
using ApiDomain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ApiDataTest
{
    public class UfGets : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvide;
        public UfGets(DbTeste dbTeste)
        {
            _serviceProvide = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName ="Gets de UF")]
        [Trait("GETs","UfEntity")]
        public async Task E_Possivel_Realizar_Gets_Uf()
        {
            using(var context = _serviceProvide.GetService<MyContext>())
            {
                UfImplementation _repositorio = new UfImplementation(context);

                UfEntity _entiy = new UfEntity
                {
                    Id = new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                    Sigla = "AC",
                    Nome = "Acre"
                };

                var _registroExiste = await _repositorio.ExistAsync(_entiy.Id);
                Assert.True(_registroExiste);

                var _registroSelecionado = await _repositorio.SelectAsync(_entiy.Id);
                Assert.NotNull(_registroSelecionado);
                Assert.Equal(_entiy.Sigla, _registroSelecionado.Sigla);
                Assert.Equal(_entiy.Nome, _registroSelecionado.Nome);
                Assert.Equal(_entiy.Id, _registroSelecionado.Id);

                var _todosRegistros = await _repositorio.SelectAsync();
                Assert.NotNull(_todosRegistros);
                Assert.True(_todosRegistros.Count() == 2);
            }
        }
    }
}
