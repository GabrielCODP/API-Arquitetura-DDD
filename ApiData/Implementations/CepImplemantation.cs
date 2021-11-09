using ApiData.Context;
using ApiData.Repository;
using ApiDomain.Entities;
using ApiDomain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiData.Implementations
{
    public class CepImplemantation : BaseRepository<CepEntity>, ICepRepository
    {
        private DbSet<CepEntity> _dataSet;

        public CepImplemantation(MyContext context) : base(context)
        {
            _dataSet = context.Set<CepEntity>();
        }


        public async Task<CepEntity> SelectAsync(string cep)
        {
            return await _dataSet.Include(c => c.Municipio).ThenInclude(m => m.Uf).SingleOrDefaultAsync(u => u.Cep.Equals(cep));
        }
    }
}
