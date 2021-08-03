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

            var connectioString = "server=localhost;userid=root;port=3306;password=78#P9865@;database=CursoApi";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectioString);
            return new MyContext(optionsBuilder.Options);

        }
    }
}
