using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string ruta = ConfigurationManager.AppSettings["ruta_archivo"].ToString();
            Debug.WriteLine("Ruta : " + ruta);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}