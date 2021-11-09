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

namespace ApiApplicationTest.Usuario.QuandoRequisitarOCreated
{
    public class Retorno_Created
    {
        private UsersController _controller;

        [Fact(DisplayName = "É possível Realizar o Created")]
        public async Task É_Possivel_Invocar_a_Controller_Create()
        {
            var serviceMock = new Mock<IUserService>();
            var nome = Faker.Name.FullName();
            var email = Faker.Internet.Email();

            serviceMock.Setup(m => m.Post(It.IsAny<UserDtoCreate>())).ReturnsAsync(
                  new UserDtoCreateResult 
                  {
                    Id = Guid.NewGuid(),
                    Nome = nome,
                    Email = email,
                    CreateAt = DateTime.UtcNow
                  }

                );

            _controller = new UsersController(serviceMock.Object);

            Mock<IUrlHelper> url = new Mock<IUrlHelper>();
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost:5000");
            _controller.Url = url.Object;

            var userDtoCreate = new UserDtoCreate
            {
                Nome = nome,
                Email = email
            };

            var result = await _controller.Post(userDtoCreate);
            Assert.True(result is CreatedResult);

            var resultValue = ((CreatedResult)result).Value as UserDtoCreateResult;
            Assert.NotNull(resultValue);
            Assert.Equal(userDtoCreate.Nome, resultValue.Nome);
            Assert.Equal(userDtoCreate.Email, resultValue.Email);
        }
    }
}
