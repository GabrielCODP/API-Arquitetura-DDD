using ApiDomain.Dtos.User;
using ApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserDto> Get(Guid id);

        //Uma lista de usuário, não é um método e sim uma declaração
        Task<IEnumerable<UserDto>> GetAll();

        Task<UserDtoCreateResult> Post(UserDto user);
        Task<UserDtoUpdateResult> Put(UserDto user);
        Task<bool> Delete(Guid id);

    }
}
