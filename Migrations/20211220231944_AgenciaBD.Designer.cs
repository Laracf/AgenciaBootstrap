﻿// <auto-generated />
using System;
using Agencia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agencia.Migrations
{
    [DbContext(typeof(AgenciaContext))]
    [Migration("20211220231944_AgenciaBD")]
    partial class AgenciaBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Agencia.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Agencia.Models.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<string>("DataIda")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DataVolta")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("DestinoIdDestino")
                        .HasColumnType("int");

                    b.Property<int>("FK_IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("FK_IdDestino")
                        .HasColumnType("int");

                    b.Property<int>("valor")
                        .HasColumnType("int");

                    b.HasKey("IdCompra");

                    b.HasIndex("ClienteIdCliente");

                    b.HasIndex("DestinoIdDestino");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Agencia.Models.Destino", b =>
                {
                    b.Property<int>("IdDestino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDestino");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("Agencia.Models.Compra", b =>
                {
                    b.HasOne("Agencia.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteIdCliente");

                    b.HasOne("Agencia.Models.Destino", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoIdDestino");

                    b.Navigation("Cliente");

                    b.Navigation("Destino");
                });
#pragma warning restore 612, 618
        }
    }
}
