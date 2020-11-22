using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea9y10.Models;

namespace Tarea9y10.Controllers
{
    public class IntegrantesController : Controller
    {

        AplicacionDbContext bd = new AplicacionDbContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {

            return View("Create", new Integrantes());

        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Integrantes integrantes)
        {

                bd.Integrantes.Add(integrantes);
                bd.SaveChanges();
                return RedirectToAction("Index");
           
        }
    }
}