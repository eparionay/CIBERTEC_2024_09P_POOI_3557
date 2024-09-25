using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web01.Models;

namespace Web01.Controllers
{
    public class LaptopController : Controller
    {
        public static int contador = 0;
        public static List<Laptop> lista;
        public LaptopController()
        {

            if (lista == null)
            {
                lista = new List<Laptop>();
                lista.Add(new Laptop()
                {
                    codigo = 1,
                    marca = "Hp",
                    precioDolar = 700,
                    color = "Gris"
                });
                lista.Add(new Laptop()
                {
                    codigo = 2,
                    marca = "Toshiba",
                    precioDolar = 800,
                    color = "Negro"
                });
                contador = lista.Count;
            }

            Debug.WriteLine("Ini LaptopController");
        }


        // GET: Laptop
        public ActionResult Index()
        {
            ViewBag.Nombre = "Carlos";
            ViewBag.Apellido = "Perez";
            ViewBag.salario = 1500;
            return View();
        }

        [HttpGet]
        public ActionResult crearLaptop()
        {

            return View(new Laptop());
        }

        [HttpPost]
        public ActionResult crearLaptop(Laptop obj)
        {

            Debug.WriteLine("Codigo : " + obj.codigo);
            Debug.WriteLine("Marca : " + obj.marca);
            Debug.WriteLine("Precio $ : " + obj.precioDolar);
            Debug.WriteLine("Color : " + obj.color);
            Debug.WriteLine("Precio S/ : " + obj.getPrecioSoles());
            string mensaje;
            int indice = lista.FindIndex(x => x.codigo == obj.codigo);
            if (indice == -1)
            {
                lista.Add(obj);
                contador++;
                mensaje = "El registro fue agregado a la lista";
                Debug.WriteLine("El codigo ingresado no existe");
            }
            else
            {
                mensaje = "El codigo de registro ya existe";
                Debug.WriteLine("El codigo ingresado existe");
                Debug.WriteLine("Posicion : " + indice);
            }

            ViewBag.ContadorRegistros = contador;
            ViewBag.MensajeValidacion = mensaje;
            Debug.WriteLine("Total Registros : " + lista.Count);
            return View(obj);
        }

        public ActionResult ListadoLaptop()
        {

            return View(lista);
        }



    }
}