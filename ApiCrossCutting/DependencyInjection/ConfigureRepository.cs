using ApiData.Context;
using ApiData.Implementations;
using ApiData.Repository;
using ApiDomain.Interfaces;
using ApiDomain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            //Uma conexão de banco,devolver um tipo exato
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            serviceCollection.AddDbContext<MyContext>(
               options => options.UseMySql("server=localhost;userid=root;port=3306;password=78#P9865@;database=cursoapi")
               );
        }
    }
}
