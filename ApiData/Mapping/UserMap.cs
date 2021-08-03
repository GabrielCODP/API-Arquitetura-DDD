using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            //Quando for criar essa tabela no banco, vai criar com base nesses entidades 

            builder.ToTable("User");

            //Definir a chave primaria, vai ser o Id do UserEntity
            builder.HasKey(u => u.Id);

            //Não pode ter 2 emails iguais.
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(60);
            builder.Property(u => u.Email).HasMaxLength(100);

        }
    }
}
