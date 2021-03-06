﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea9y10.Models;

namespace Tarea9y10.Migrations
{
    [DbContext(typeof(AplicacionDbContext))]
    partial class AplicacionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Tarea9y10.Models.DatosAcademicos", b =>
                {
                    b.Property<int>("DatosAcademicosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExplusadoSuspendido")
                        .HasColumnType("TEXT");

                    b.Property<string>("NivelEstudio")
                        .HasColumnType("TEXT");

                    b.Property<string>("RazonEXSUS")
                        .HasColumnType("TEXT");

                    b.HasKey("DatosAcademicosId");

                    b.ToTable("DatosAcademicos");
                });

            modelBuilder.Entity("Tarea9y10.Models.DatosEclesiasticos", b =>
                {
                    b.Property<int>("DatosEclesiasticosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CantVecesDisciplina")
                        .HasColumnType("TEXT");

                    b.Property<string>("CausaDisciplina")
                        .HasColumnType("TEXT");

                    b.Property<string>("DenominacionPerteneciente")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiosLlamado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Disciplinatura")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaAceptadoIglesia")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaBautismo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaConversion")
                        .HasColumnType("TEXT");

                    b.Property<string>("FuncionesOcupa")
                        .HasColumnType("TEXT");

                    b.Property<string>("IglesiaAnterior")
                        .HasColumnType("TEXT");

                    b.Property<string>("MetasVida")
                        .HasColumnType("TEXT");

                    b.Property<string>("MinisterioServidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("MinisteriosFrutosPQ")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreIglesiaActual")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombrePastorActual")
                        .HasColumnType("TEXT");

                    b.Property<string>("RespaldoEstudios")
                        .HasColumnType("TEXT");

                    b.HasKey("DatosEclesiasticosId");

                    b.ToTable("DatosEclesiasticos");
                });

            modelBuilder.Entity("Tarea9y10.Models.DatosFamiliares", b =>
                {
                    b.Property<int>("DatosFamiliaresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CantidadHijos")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hijos_Si_No")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombrePareja")
                        .HasColumnType("TEXT");

                    b.HasKey("DatosFamiliaresId");

                    b.ToTable("DatosFamiliares");
                });

            modelBuilder.Entity("Tarea9y10.Models.DatosLaborales", b =>
                {
                    b.Property<int>("DatosLaboralesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomEmpresaNegocio")
                        .HasColumnType("TEXT");

                    b.Property<string>("OcupacionActual")
                        .HasColumnType("TEXT");

                    b.Property<string>("Profesion")
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonoEmpresaNegocio")
                        .HasColumnType("TEXT");

                    b.HasKey("DatosLaboralesId");

                    b.ToTable("DatosLaborales");
                });

            modelBuilder.Entity("Tarea9y10.Models.Direccion", b =>
                {
                    b.Property<int>("DireccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Calle")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumVivienda")
                        .HasColumnType("TEXT");

                    b.Property<string>("Provincia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sector")
                        .HasColumnType("TEXT");

                    b.HasKey("DireccionId");

                    b.ToTable("Direccion");
                });

            modelBuilder.Entity("Tarea9y10.Models.DocumentoIdentificacion", b =>
                {
                    b.Property<int>("DocIdentidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreDocumento")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("TEXT");

                    b.HasKey("DocIdentidadId");

                    b.ToTable("DocumentoIdentificacion");
                });

            modelBuilder.Entity("Tarea9y10.Models.Integrantes", b =>
                {
                    b.Property<int>("IntegranteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("CiudadNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("CiudadResidenciaAct")
                        .HasColumnType("TEXT");

                    b.Property<int>("DatosAcademicosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DatosEclesiasticosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DatosFamiliaresId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DatosLaboralesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DireccionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DocIdentidadId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaisNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaisResidenciaAct")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("IntegranteId");

                    b.ToTable("Integrantes");
                });
#pragma warning restore 612, 618
        }
    }
}
