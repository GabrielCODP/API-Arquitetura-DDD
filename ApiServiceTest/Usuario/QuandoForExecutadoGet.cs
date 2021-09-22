using ApiDomain.Dtos.User;
using ApiDomain.Interfaces.Services.User;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiServiceTest.Usuario
{
    
    public class QuandoForExecutadoGet : UsuarioTestes
    {
        private IUserService _service;

        //Ele mokar,ele vai emitar todos os metos que tem dentro da IUserService, colocando em uma memoria, mostrando assim a entrada e saida.
        private Mock<IUserService> _serviceMock;

        [Fact(DisplayName = "É Possível Executar o Método GET.")]
        public async Task E_Possivel_Executar_Metodo_Get()
        {
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Get(IdUsuario)).ReturnsAsync(userDto);
            _service = _serviceMock.Object;

            //Verficar se a respota da service e com a mémoria deu corretamente
            var result = await _service.Get(IdUsuario);
            Assert.NotNull(result);
            Assert.True(result.Id==IdUsuario);
            Assert.Equal(NomeUsuario, result.Nome);

            //Quero que o retorno seja nullo
            _serviceMock = new Mock<IUserService>();

            //Pode ser qualquer Guid
            _serviceMock.Setup(m => m.Get(It.IsAny<Guid>())).Returns(Task.FromResult((UserDto)null));
            _service = _serviceMock.Object;

            var _record = await _service.Get(IdUsuario);
            Assert.Null(_record);
        }
    }
}
