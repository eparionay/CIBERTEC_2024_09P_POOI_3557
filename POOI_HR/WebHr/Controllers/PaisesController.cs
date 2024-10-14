using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebHr.Models;
using WebHr.servicio;

namespace WebHr.Controllers
{
    public class PaisesController : Controller
    {
        // GET: Paises
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult reporte()
        {
            ServicioPais servicio = new ServicioPais();
            return View(servicio.operacionesLectura("ConsultarTodo", ""));
        }
        
        [HttpGet]
        public ActionResult CrearPais()
        {
            ViewBag.comboRegiones = new SelectList(
                listaRegiones(), "region_id", "region_name"
                );

            return View(new Pais());
        }
        
        [HttpPost]
        public ActionResult CrearPais(Pais p)
        {
            Debug.WriteLine("Codigo : " + p.country_id);
            Debug.WriteLine("Nombre : " + p.country_name);
            Debug.WriteLine("Region : " + p.region_id);

            if (ModelState.IsValid)
            {
                ServicioPais servicio = new ServicioPais();
                int procesar = servicio.operacionesEscritura("Insertar", p);
                if (procesar >= 0)
                {
                    return RedirectToAction("reporte");
                }
            }
            return View(p);
        }

        [HttpGet]
        public ActionResult Editar(string codigo)
        {
            ServicioPais servicio = new ServicioPais();
            List<Pais> lista = servicio.operacionesLectura("ConsultarXId", codigo);
            return View(lista.First());
        }

        [HttpPost]
        public ActionResult Editar(Pais p)
        {
            ServicioPais servicio = new ServicioPais();
            int procesar = servicio.operacionesEscritura("Actualizar", p);
            if (procesar >= 0)
            {
                return RedirectToAction("reporte");
            }

            return View(p);
        }

        public ActionResult Detalle(string codigo)
        {
            ServicioPais servicio = new ServicioPais();
            List<Pais> lista = servicio.operacionesLectura("ConsultarXId", codigo);
            return View(lista.First());
        }

        public ActionResult Eliminar(string codigo)
        {
            ServicioPais servicio = new ServicioPais();
            List<Pais> lista = servicio.operacionesLectura("ConsultarXId", codigo);
            return View(lista.First());
        }

        [HttpPost, ActionName("Eliminar")]
        public ActionResult Eliminar_Confirmar(string codigo)
        {
            ServicioPais servicio = new ServicioPais();
            Pais p = new Pais();
            p.region_id = 0;
            p.country_name = "";
            p.country_id = codigo;
            int procesar = servicio.operacionesEscritura("Eliminar", p);

            if (procesar >= 0)
            {
                return RedirectToAction("reporte");
            }
            return View();
        }

        public List<Region> listaRegiones()
        {
            
    
            /*
            Region region1= new Region();
            region1.region_id = 1;
            region1.region_name = "America";
            Region region2 = new Region();
            region2.region_id = 2;
            region2.region_name = "Europa";
            listaRegiones.Add(region1);
            listaRegiones.Add(region2);*/
            ServicioRegion servicioRegion = new ServicioRegion();
            List<Region> listaRegiones = servicioRegion.operacionesLectura("ConsultarTodo",0);
            return listaRegiones;
        }





    }
}