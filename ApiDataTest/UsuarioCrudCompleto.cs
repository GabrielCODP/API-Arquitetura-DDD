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
    public class UsuarioCrudCompleto : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvide;

        public UsuarioCrudCompleto(DbTeste  dbTeste)
        {
            _serviceProvide = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName ="Crud de Usuário")]
        [Trait("CRUD","UserEntity")]
        public async Task E_Possivel_Realizar_Crud_Usuario()
        {
            using (var context = _serviceProvide.GetService<MyContext>())
            {
                UserImplementation _repositorio = new UserImplementation(context);
                UserEntity _entity = new UserEntity
                {
                    //Vai gerar um nome e email aleatorio
                    Email = Faker.Internet.Email(),
                    Nome = Faker.Name.FullName()

                };

                var _registroCriado = await _repositorio.InsertAsync(_entity);
                Assert.NotNull(_registroCriado);
                Assert.Equal(_entity.Email, _registroCriado.Email);
                Assert.Equal(_entity.Nome, _registroCriado.Nome);
                Assert.False(_registroCriado.Id == Guid.Empty);

                _entity.Nome = Faker.Name.First();
                var _registroAtualizado = await _repositorio.UpdateAsync(_entity);
                Assert.NotNull(_registroAtualizado);
                Assert.Equal(_entity.Email, _registroAtualizado.Email);
                Assert.Equal(_entity.Nome, _registroAtualizado.Nome);

                var _registroExiste = await _repositorio.ExistAsync(_registroAtualizado.Id);
                Assert.True(_registroExiste);

                var _registroSelecionado = await _repositorio.SelectAsync(_registroAtualizado.Id);
                Assert.NotNull(_registroSelecionado);
                Assert.Equal(_registroAtualizado.Email, _registroSelecionado.Email);
                Assert.Equal(_registroAtualizado.Nome,_registroSelecionado.Nome);

                var _todosRegistros = await _repositorio.SelectAsync();
                Assert.NotNull(_todosRegistros);
                Assert.True(_todosRegistros.Count() > 1);

                var _removeu = await _repositorio.DeleteAsync(_registroSelecionado.Id);
                Assert.True(_removeu);


                var _usuarioPadrao = await _repositorio.FindByLogin("Dexter@gmail.com");
                Assert.NotNull(_usuarioPadrao);
                Assert.Equal("Dexter@gmail.com", _usuarioPadrao.Email);
                Assert.Equal("Administrador", _usuarioPadrao.Nome);
            }
        
        }
    }
}
