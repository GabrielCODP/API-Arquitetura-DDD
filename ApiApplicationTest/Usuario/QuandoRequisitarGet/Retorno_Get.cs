
using ApiApplication.Controllers;
using ApiDomain.Dtos.User;
using ApiDomain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiApplicationTest.Usuario.QuandoRequisitarGet
{
    public class Retorno_Get
    {
        private UsersController _controller;

        [Fact(DisplayName = "É possível realizar o Get.")]
        public async Task E_Possivel_Invocar_a_Controller_Get()
        {
            var serviceMock = new Mock<IUserService>();
            var nome = Faker.Name.FullName();
            var email = Faker.Internet.Email();

            serviceMock.Setup(m => m.Get(It.IsAny<Guid>())).ReturnsAsync(
                 new UserDto
                 {
                    Id = Guid.NewGuid(),
                    Nome = nome,
                    Email =email,
                    CreateAt = DateTime.UtcNow
                  }
               );

            _controller = new UsersController(serviceMock.Object);
            var result = await _controller.GetId(Guid.NewGuid());
            Assert.True(result is OkObjectResult);
            var resultValue = ((OkObjectResult)result).Value as UserDto;
            Assert.NotNull(resultValue);
            Assert.Equal(nome, resultValue.Nome);
            Assert.Equal(email, resultValue.Email);
        }
    }
}
