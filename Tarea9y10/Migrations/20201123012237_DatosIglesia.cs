using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea9y10.Migrations
{
    public partial class DatosIglesia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatosAcademicos",
                columns: table => new
                {
                    DatosAcademicosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NivelEstudio = table.Column<string>(type: "TEXT", nullable: true),
                    ExplusadoSuspendido = table.Column<string>(type: "TEXT", nullable: true),
                    RazonEXSUS = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosAcademicos", x => x.DatosAcademicosId);
                });

            migrationBuilder.CreateTable(
                name: "DatosEclesiasticos",
                columns: table => new
                {
                    DatosEclesiasticosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaConversion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaBautismo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaAceptadoIglesia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DenominacionPerteneciente = table.Column<string>(type: "TEXT", nullable: true),
                    NombreIglesiaActual = table.Column<string>(type: "TEXT", nullable: true),
                    IglesiaAnterior = table.Column<string>(type: "TEXT", nullable: true),
                    NombrePastorActual = table.Column<string>(type: "TEXT", nullable: true),
                    Disciplinatura = table.Column<string>(type: "TEXT", nullable: true),
                    CantVecesDisciplina = table.Column<string>(type: "TEXT", nullable: true),
                    CausaDisciplina = table.Column<string>(type: "TEXT", nullable: true),
                    FuncionesOcupa = table.Column<string>(type: "TEXT", nullable: true),
                    MinisterioServidos = table.Column<string>(type: "TEXT", nullable: true),
                    MinisteriosFrutosPQ = table.Column<string>(type: "TEXT", nullable: true),
                    DiosLlamado = table.Column<string>(type: "TEXT", nullable: true),
                    MetasVida = table.Column<string>(type: "TEXT", nullable: true),
                    RespaldoEstudios = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosEclesiasticos", x => x.DatosEclesiasticosId);
                });

            migrationBuilder.CreateTable(
                name: "DatosFamiliares",
                columns: table => new
                {
                    DatosFamiliaresId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstadoCivil = table.Column<string>(type: "TEXT", nullable: true),
                    NombrePareja = table.Column<string>(type: "TEXT", nullable: true),
                    CantidadHijos = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosFamiliares", x => x.DatosFamiliaresId);
                });

            migrationBuilder.CreateTable(
                name: "DatosLaborales",
                columns: table => new
                {
                    DatosLaboralesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Profesion = table.Column<string>(type: "TEXT", nullable: true),
                    OcupacionActual = table.Column<string>(type: "TEXT", nullable: true),
                    NomEmpresaNegocio = table.Column<string>(type: "TEXT", nullable: true),
                    TelefonoEmpresaNegocio = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosLaborales", x => x.DatosLaboralesId);
                });

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    DireccionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Provincia = table.Column<string>(type: "TEXT", nullable: true),
                    Sector = table.Column<string>(type: "TEXT", nullable: true),
                    Calle = table.Column<string>(type: "TEXT", nullable: true),
                    NumVivienda = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.DireccionId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentoIdentificacion",
                columns: table => new
                {
                    DocIdentidadId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    RNC = table.Column<string>(type: "TEXT", nullable: true),
                    Pasaporte = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoIdentificacion", x => x.DocIdentidadId);
                });

            migrationBuilder.CreateTable(
                name: "Integrantes",
                columns: table => new
                {
                    IntegranteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Sexo = table.Column<string>(type: "TEXT", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PaisNacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Foto = table.Column<string>(type: "TEXT", nullable: true),
                    CiudadNacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    PaisResidenciaAct = table.Column<string>(type: "TEXT", nullable: true),
                    CiudadResidenciaAct = table.Column<string>(type: "TEXT", nullable: true),
                    DireccionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Celular = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    DocIdentidadId = table.Column<int>(type: "INTEGER", nullable: false),
                    DatosFamiliaresId = table.Column<int>(type: "INTEGER", nullable: false),
                    DatosLaboralesId = table.Column<int>(type: "INTEGER", nullable: false),
                    DatosEclesiasticosId = table.Column<int>(type: "INTEGER", nullable: false),
                    DatosAcademicosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrantes", x => x.IntegranteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosAcademicos");

            migrationBuilder.DropTable(
                name: "DatosEclesiasticos");

            migrationBuilder.DropTable(
                name: "DatosFamiliares");

            migrationBuilder.DropTable(
                name: "DatosLaborales");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "DocumentoIdentificacion");

            migrationBuilder.DropTable(
                name: "Integrantes");
        }
    }
}
