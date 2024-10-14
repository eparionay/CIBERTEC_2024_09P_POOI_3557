using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHr.Models;
using WebHr.servicio;

namespace WebHr.Controllers
{
    public class EjemploController : Controller
    {
        // GET: Ejemplo
        public ActionResult Index(string nombre, string apellido)
        {
            ViewBag.listaRegion = new SelectList(listaRegiones(), "region_id", "region_name");
            return View();
        }

        public List<Region> listaRegiones()
        {
            ServicioRegion servicioRegion = new ServicioRegion();
            List<Region> listaRegiones = servicioRegion.operacionesLectura("ConsultarTodo", 0);
            return listaRegiones;
        }


    }
}