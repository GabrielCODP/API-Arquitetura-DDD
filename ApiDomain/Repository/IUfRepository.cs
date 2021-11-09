using ApiDomain.Entities;
using ApiDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Repository
{
    public interface IUfRepository : IRepository<UfEntity>
    {
        //Não preciso de nenhum método especifico até agora, por causa da oasta Seeds-UfSeeds(Já que tem os dados da UF)
    }
}
