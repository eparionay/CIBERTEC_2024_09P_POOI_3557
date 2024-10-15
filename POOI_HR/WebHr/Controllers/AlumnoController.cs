using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHr.Models;
using WebHr.servicio;

namespace WebHr.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            ServicioAlumno serviceAlumno= new ServicioAlumno();
            List<Alumno> lista= serviceAlumno.listaAlumno();
            return View(lista);
        }




    }
}