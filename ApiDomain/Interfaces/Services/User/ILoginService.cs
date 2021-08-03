using ApiDomain.Dtos;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
