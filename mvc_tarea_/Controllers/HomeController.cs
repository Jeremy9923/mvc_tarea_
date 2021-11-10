using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_tarea_.Models;
namespace mvc_tarea_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Personal = new personal()
            {

                nombre = "Jeremy", apellido = "Benavides", edad = 21, correo = "jeremybena99@gmail.com", direccion = "san miguel", Telefono = "5555-5555"
            };

            return View(Personal);
        }

    }
}