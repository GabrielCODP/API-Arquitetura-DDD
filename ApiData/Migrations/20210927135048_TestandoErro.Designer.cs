﻿// <auto-generated />
using System;
using ApiData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiData.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210927135048_TestandoErro")]
    partial class TestandoErro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiDomain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a5792cc-6be5-448b-91e1-81cbc0b57652"),
                            CreateAt = new DateTime(2021, 9, 27, 10, 50, 48, 539, DateTimeKind.Local).AddTicks(5539),
                            Email = "Dexter@gmail.com",
                            Nome = "Administrador",
                            UpdateAt = new DateTime(2021, 9, 27, 10, 50, 48, 540, DateTimeKind.Local).AddTicks(2376)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}