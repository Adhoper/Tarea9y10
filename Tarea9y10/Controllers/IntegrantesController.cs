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
using Microsoft.EntityFrameworkCore;


namespace Tarea9y10.Controllers
{
    public class IntegrantesController : Controller
    {

        AplicacionDbContext bd = new AplicacionDbContext();
        ViewModel vm = new ViewModel();

        private readonly IWebHostEnvironment webHostEnviroment;

        public IntegrantesController(IWebHostEnvironment webHostEnvironments)
        {
            webHostEnviroment = webHostEnvironments;
        }


        [Route("~/{id?}")]
        public IActionResult Index(string id)
        {

            if (!String.IsNullOrEmpty(id))
            {
                ViewBag.id = id;
            }

            return View();
        }


        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();

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
        #region Create

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Integrantes integrantes,Direccion direccion,DocumentoIdentificacion documento,DatosFamiliares familiares,DatosAcademicos academicos,DatosEclesiasticos eclesiasticos,DatosLaborales laborales,ImagesModel imgModel)
        {
            //Agregar tipo de Documento

            string wey = Request.Form["idc"];
            if (wey == "Cedula")
            {
                documento.TipoDocumento = "Cedula";
            }
            else if (wey == "RNC")
            {
                documento.TipoDocumento = "RNC";
            }
            else
            {
                documento.TipoDocumento = "Pasaporte";
            }

            //Adjuntar Documento

            string stringFileNameDoc = UploadFileDoc(imgModel);
            var ss = new DocumentoIdentificacion
            {
                NombreDocumento = stringFileNameDoc
            };
            
            documento.NombreDocumento = stringFileNameDoc;

            
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
            bd.DocumentoIdentificacion.Add(documento);
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

            //Agregar Imagen
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
        #endregion

        //Agregar la imagen a la carpeta Imagenes2x2
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

        //Agregar los documentos o imagenes a la carpeta Documentos
        private string UploadFileDoc(ImagesModel imgModel)
        {
            string fileName = null;
            if (imgModel.Documento != null)
            {
                string uploadDir = Path.Combine(webHostEnviroment.WebRootPath, "Documentos");
                fileName = imgModel.Documento.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);

                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    imgModel.Documento.CopyTo(fileStream);
                }


            }
            return fileName;
        }
        [HttpGet]
        [Route("Delete")]
        public IActionResult Delete(int? id)
        {
            #region BorrarArchivos

            //Borrar foto
            var integrantesD = from ints in bd.Integrantes
                               where ints.IntegranteId == id
                               select ints;

            foreach (var d in integrantesD) {

                string fileName = ("wwwroot/Imagenes2x2/" + d.Foto);

                if (fileName != null || fileName != string.Empty)
                {
                    if ((System.IO.File.Exists(fileName)))
                    {
                        System.IO.File.Delete(fileName);
                    }

                }
            }

            //Borrar Documento
            var documentoIdnt = from doc in bd.DocumentoIdentificacion
                                where doc.DocIdentidadId == id
                                select doc;

            foreach (var d in documentoIdnt)
            {

                string fileName = ("wwwroot/Documentos/" + d.NombreDocumento);

                if (fileName != null || fileName != string.Empty)
                {
                    if ((System.IO.File.Exists(fileName)))
                    {
                        System.IO.File.Delete(fileName);
                    }

                }
            }

            #endregion

            bd.Direccion.Remove(bd.Direccion.Find(id));
            bd.DocumentoIdentificacion.Remove(bd.DocumentoIdentificacion.Find(id));
            bd.DatosAcademicos.Remove(bd.DatosAcademicos.Find(id));
            bd.DatosEclesiasticos.Remove(bd.DatosEclesiasticos.Find(id));
            bd.DatosFamiliares.Remove(bd.DatosFamiliares.Find(id));
            bd.DatosLaborales.Remove(bd.DatosLaborales.Find(id));


            bd.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}