using ApiData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDataTest
{
    public abstract class BaseTest
    {
        public BaseTest()
        {

        }
    }

    public class DbTeste : IDisposable
    {
        //Um banco de dados, para testar o teste
        private string dataBaseName = $"dbAPITest_{Guid.NewGuid().ToString().Replace("-", string.Empty)}";
        public ServiceProvider ServiceProvider { get; private set; }

        public DbTeste()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<MyContext>(o => o.UseMySql($"server=localhost;userid=root;port=3306;password=78#P9865@;database={dataBaseName}"),
                ServiceLifetime.Transient);//Criar um DB a cada requisição
            ServiceProvider = serviceCollection.BuildServiceProvider();
            using(var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureCreated();
            }
                
        }
        public void Dispose()
        {
           //Garantir que o Db vai ser criado e depois eliminado 
            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureDeleted();
            }

        }
    }
}
