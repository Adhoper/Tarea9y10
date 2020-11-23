using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea9y10.ImageModel;
using Tarea9y10.Models;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Tarea9y10.Controllers
{
    public class IntegrantesController : Controller
    {

        AplicacionDbContext bd = new AplicacionDbContext();

        private readonly IWebHostEnvironment webHostEnviroment;

        public IntegrantesController(IWebHostEnvironment webHostEnvironments)
        {
            webHostEnviroment = webHostEnvironments;
        }
        public IActionResult Index()
        {
            
            return View(bd);
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            ModelPaises MP = new ModelPaises();
            
            //Trae todos los paises
            ViewBag.Paises = MP.ListaPaises();

            return View("Create", new ViewModel());

        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Integrantes integrantes,Direccion direccion,DocumentoIdentificacion documento,DatosFamiliares familiares,DatosAcademicos academicos,DatosEclesiasticos eclesiasticos,DatosLaborales laborales,ImagesModel imgModel)
        {


            string DocIdent = Request.Form["identificacion"];

            if (DocIdent == "Cedula")
            {
                //documento.Cedula
            }
            else if (DocIdent == "RNC")
            {
                //documento.RNC
            }
            else
            {
                //documento.Pasaporte
            }

            bd.DocumentoIdentificacion.Add(documento);
            bd.SaveChanges();
            bd.DatosFamiliares.Add(familiares);
            bd.SaveChanges();
            bd.DatosAcademicos.Add(academicos);
            bd.SaveChanges();
            bd.DatosEclesiasticos.Add(eclesiasticos);
            bd.SaveChanges();
            bd.DatosLaborales.Add(laborales);
            bd.SaveChanges();
            bd.Direccion.Add(direccion);
            bd.SaveChanges();

            foreach (var direc in bd.Direccion)
            {
                integrantes.DireccionId = direc.DireccionId;
            }
            foreach (var fam in bd.DatosFamiliares)
            {
                integrantes.DatosFamiliaresId = fam.DatosFamiliaresId;
            }
            foreach (var aca in bd.DatosAcademicos)
            {
                integrantes.DatosAcademicosId = aca.DatosAcademicosId;
            }
            foreach (var ecle in bd.DatosEclesiasticos)
            {
                integrantes.DatosEclesiasticosId = ecle.DatosEclesiasticosId;
            }
            foreach (var doc in bd.DocumentoIdentificacion)
            {
                integrantes.DocIdentidadId = doc.DocIdentidadId;
            }
            foreach (var lab in bd.DatosLaborales)
            {
                integrantes.DatosLaboralesId = lab.DatosLaboralesId;
            }

            string stringFileName = UploadFile(imgModel);
            var integrante = new Integrantes
            {
                 Foto = stringFileName
            };

            integrantes.Foto = stringFileName;
            

            bd.Integrantes.Add(integrantes);
            bd.SaveChanges();

            return RedirectToAction("Index");
           
        }


        private string UploadFile(ImagesModel imgModel)
        {
            string fileName = null;
            if (imgModel.Foto!=null)
            {
                string uploadDir = Path.Combine(webHostEnviroment.WebRootPath,"Imagenes2x2");
                fileName = Guid.NewGuid().ToString() + "-" + imgModel.Foto.FileName;
                string FilePath = Path.Combine(uploadDir,fileName);

                using (var fileStream = new FileStream(FilePath,FileMode.Create))
                {
                    imgModel.Foto.CopyTo(fileStream);
                }

                
            }
            return fileName;
        }
       

        
    }
}