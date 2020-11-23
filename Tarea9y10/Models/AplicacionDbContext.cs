using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Tarea9y10.Models
{
    public class AplicacionDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite("Data Source=IglesiaData.db");

        public DbSet<Integrantes> Integrantes { get; set; }
        public DbSet<Direccion> Direccion { get; set; }

        public DbSet<DocumentoIdentificacion> DocumentoIdentificacion { get; set; }
        public DbSet<DatosFamiliares> DatosFamiliares { get; set; }
        public DbSet<DatosLaborales> DatosLaborales { get; set; }
        public DbSet<DatosEclesiasticos> DatosEclesiasticos { get; set; }
        public DbSet<DatosAcademicos> DatosAcademicos { get; set; }
    }

    public class Integrantes
    {
        [Key]
        public int IntegranteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Pais de Nacimiento")]
        public string PaisNacimiento { get; set; }
        public string Foto { get; set; }
        [Display(Name = "Ciudad de Nacimiento")]
        public string CiudadNacimiento { get; set; }
        [Display(Name = "Pais de Residencia Actual")]
        public string PaisResidenciaAct { get; set; }
        [Display(Name = "Ciudad de Residencia Actual")]
        public string CiudadResidenciaAct { get; set; }
        public int DireccionId { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int DocIdentidadId { get; set; }
        public int DatosFamiliaresId { get; set; }
        public int DatosLaboralesId { get; set; }
        public int DatosEclesiasticosId { get; set; }
        public int DatosAcademicosId { get; set; }


    }

    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        public string Provincia { get; set; }
        public string Sector { get; set; }
        public string Calle { get; set; }
        [Display(Name = "Num. de Vivienda")]
        public string NumVivienda { get; set; }
    }

    public class DocumentoIdentificacion
    {
        [Key]
        public int DocIdentidadId { get; set; }
        public string Cedula { get; set; }
        public string RNC { get; set; }
        public string Pasaporte { get; set; }
    }

    public class DatosFamiliares
    {
        [Key]
        public int DatosFamiliaresId { get; set; }
        public string EstadoCivil { get; set; }
        public string NombrePareja { get; set; }

        public string CantidadHijos { get; set; }
    }

    public class DatosLaborales
    {
        [Key]
        public int DatosLaboralesId { get; set; }
        public string Profesion { get; set; }
        public string OcupacionActual { get; set; }
        public string NomEmpresaNegocio { get; set; }
        public string TelefonoEmpresaNegocio { get; set; }
    }

    public class DatosEclesiasticos
    {
        [Key]
        public int DatosEclesiasticosId { get; set; }

        [Display(Name = "Fecha de Conversion")]
        public DateTime FechaConversion { get; set; }
        [Display(Name = "Fecha de Bautismo")]
        public DateTime FechaBautismo { get; set; }
        [Display(Name = "Fecha en la que fue aceptado en la Iglesia")]
        public DateTime FechaAceptadoIglesia { get; set; }

        [Display(Name = "Denominacion a la que Pertenece")]
        public string DenominacionPerteneciente { get; set; }

        public string NombreIglesiaActual { get; set; }

        public string IglesiaAnterior { get; set; }

        public string NombrePastorActual { get; set; }

        public string Disciplinatura { get; set; }
        public string CantVecesDisciplina { get; set; }

        public string CausaDisciplina { get; set; }

        public string FuncionesOcupa { get; set; }

        public string MinisterioServidos { get; set; }
        public string MinisteriosFrutosPQ { get; set; }

        public string DiosLlamado { get; set; }
        public string MetasVida { get; set; }

        public string RespaldoEstudios {get;set;}
    }

    public class DatosAcademicos
    {
        [Key]
        public int DatosAcademicosId { get; set; }

        public string NivelEstudio { get; set; }
        public string ExplusadoSuspendido { get; set; }

        public string RazonEXSUS { get; set; }
    }
}
