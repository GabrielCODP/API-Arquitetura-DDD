using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Context
{
    //Essa classe vai ajudar a criar o banco de dados, tabelas e etc,ajuda na construção de design.
    class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para crias as migrações

            var connectioString = "Colocar dados do BD";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectioString);
            return new MyContext(optionsBuilder.Options);

        }
    }
}
