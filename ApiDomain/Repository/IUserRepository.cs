using ApiDomain.Entities;
using ApiDomain.Interfaces;
using System.Threading.Tasks;

namespace ApiDomain.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        //A interface está vendo todo o Repositorio padrão (IRepository), porém vou conseguir aumentar os metodos.

        Task<UserEntity> FindByLogin(string email);
    }
}
