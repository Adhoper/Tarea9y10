using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9y10.ImageModel;

namespace Tarea9y10.Models
{

    //Clase para unir todos los modelos en un solo y poder usarlos en una vista
    public class ViewModel
    {
        public Integrantes integrantes { get; set; }
        public Direccion direccion { get; set; }
        public DocumentoIdentificacion documentoIdentificacion { get; set; }
        public DatosAcademicos academicos { get; set; }
        public DatosEclesiasticos eclesiasticos { get; set; }
        public DatosLaborales laborales { get; set; }
        public DatosFamiliares familiares { get; set; }

        public ImagesModel imgModel { get; set; } 
    }
}
