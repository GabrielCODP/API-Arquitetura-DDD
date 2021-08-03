using Microsoft.EntityFrameworkCore;
using ApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ApiData.Mapping;

namespace ApiData.Context
{
    public class MyContext : DbContext
    {
        
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Quando criar um novo objeto UserMap,configurando ele da forma escolhida.
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
        }
    }
}
