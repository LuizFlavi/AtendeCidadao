﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using atendecidadao.Data;

#nullable disable

namespace atendecidadao.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240927215555_M00")]
    partial class M00
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("atendecidadao.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@email.com.br",
                            Nome = "Administrator",
                            Perfil = 0,
                            Senha = "$2a$11$OFGW0hUAQb0f8z7m8lp0P.5tPBoFfyc9QuKGjjGrQpZoJz9Wsls5G"
                        },
                        new
                        {
                            Id = 2,
                            Email = "cliente@email.com.br",
                            Nome = "Cliente",
                            Perfil = 1,
                            Senha = "$2a$11$Zri1XNowhhTATUv1.fKvzO82u8HK/Z5uWFFhU9nyQsLFjb3NZWHpW"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}