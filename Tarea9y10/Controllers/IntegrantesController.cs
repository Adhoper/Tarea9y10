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

        public IActionResult Create()
        {
            return View();
        }
    }
}