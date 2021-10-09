﻿// <auto-generated />
using System;
using Ganaderia.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ganaderia.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211007161359_MigraInicial")]
    partial class MigraInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ganaderia.App.Dominio.Ejemplares", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Edad")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaIngresoAnimal")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreFinca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoGanado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Ejemplares");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaHistoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tratamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VacunasAplicadas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Solicitudes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaSolicitud")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GanaderoId")
                        .HasColumnType("int");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GanaderoId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Vacunas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EjemplaresId")
                        .HasColumnType("int");

                    b.Property<string>("Laboratorio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreVacuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Periosidad")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EjemplaresId");

                    b.ToTable("Vacunas");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Ganadero", b =>
                {
                    b.HasBaseType("Ganaderia.App.Dominio.Persona");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Ganadero");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("Ganaderia.App.Dominio.Persona");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Latitud")
                        .HasColumnType("real")
                        .HasColumnName("Veterinario_Latitud");

                    b.Property<float>("Longitud")
                        .HasColumnType("real")
                        .HasColumnName("Veterinario_Longitud");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Ejemplares", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.HistoriaClinica", null)
                        .WithMany("Ejemplares")
                        .HasForeignKey("HistoriaClinicaId");

                    b.HasOne("Ganaderia.App.Dominio.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Solicitudes", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.Ganadero", "Ganadero")
                        .WithMany()
                        .HasForeignKey("GanaderoId");

                    b.HasOne("Ganaderia.App.Dominio.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("Ganadero");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Vacunas", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.Ejemplares", null)
                        .WithMany("Vacunas")
                        .HasForeignKey("EjemplaresId");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Ejemplares", b =>
                {
                    b.Navigation("Vacunas");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.HistoriaClinica", b =>
                {
                    b.Navigation("Ejemplares");
                });
#pragma warning restore 612, 618
        }
    }
}
