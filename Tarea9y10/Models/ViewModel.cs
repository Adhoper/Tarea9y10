using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9y10.Models
{
    public class ViewModel
    {
        public Integrantes integrantes { get; set; }
        public Direccion direccion { get; set; }
        public DocumentoIdentificacion documentoIdentificacion { get; set; }
        public DatosAcademicos academicos { get; set; }
        public DatosEclesiasticos eclesiasticos { get; set; }
        public DatosLaborales laborales { get; set; }
        public DatosFamiliares familiares { get; set; }
    }
}
