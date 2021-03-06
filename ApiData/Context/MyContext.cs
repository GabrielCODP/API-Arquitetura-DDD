using Microsoft.EntityFrameworkCore;
using ApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ApiData.Mapping;
using ApiData.Seeds;

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

            modelBuilder.Entity<UfEntity>(new UfMap().Configure);
            modelBuilder.Entity<MunicipioEntity>(new MunicipioMap().Configure);
            modelBuilder.Entity<CepEntity>(new CepMap().Configure);

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Nome = "Administrador",
                    Email="Dexter@gmail.com",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                }
                );

            UfSeeds.Ufs(modelBuilder);
        }
    }
}
