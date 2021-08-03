using ApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces
{
    //Minha interface vai receber qualquer tipo 'T', onde ele tem que receber o tipo BaseEntity(Ou que tem herança dela)
    public interface IRepository<T>where T: BaseEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<T> SelectAsync(Guid id);

        //Retorna uma lista 
        Task<IEnumerable<T>> SelectAsync();

        Task<bool> ExistAsync(Guid id);
    }
}
