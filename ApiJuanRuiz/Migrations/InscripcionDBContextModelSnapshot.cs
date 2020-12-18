﻿// <auto-generated />
using System;
using ApiJuanRuiz.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiJuanRuiz.Migrations
{
    [DbContext(typeof(InscripcionDBContext))]
    partial class InscripcionDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ApiJuanRuiz.Entities.Casa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreCasa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Casa");
                });

            modelBuilder.Entity("ApiJuanRuiz.Entities.Inscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CasaId")
                        .HasColumnType("int");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("IdCasa")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CasaId");

                    b.ToTable("Inscripcion");
                });

            modelBuilder.Entity("ApiJuanRuiz.Entities.Inscripcion", b =>
                {
                    b.HasOne("ApiJuanRuiz.Entities.Casa", "Casa")
                        .WithMany()
                        .HasForeignKey("CasaId");

                    b.Navigation("Casa");
                });
#pragma warning restore 612, 618
        }
    }
}
