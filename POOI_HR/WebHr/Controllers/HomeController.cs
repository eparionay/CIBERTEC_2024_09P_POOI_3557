using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Diagnostics;
using System.Data.SqlClient;

namespace WebHr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString;
            Debug.WriteLine("Cadena Conexion : " +cadenaConexion);
            SqlConnection sqlCon = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            try
            {
                sqlCon = new SqlConnection(cadenaConexion);
                sqlCon.Open();
                sqlCommand = new SqlCommand("USP_COUNTRIES_CRUD", sqlCon);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.Clear();

                sqlCommand.Parameters.AddWithValue("@indicador", "ConsultarTodo");
                sqlCommand.Parameters.AddWithValue("@country_id", "");
                sqlCommand.Parameters.AddWithValue("@country_name", "");
                sqlCommand.Parameters.AddWithValue("@region_id", 0);

                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Debug.WriteLine("Codigo Pais : " + reader.GetString(0));
                    Debug.WriteLine("Nombre Pais : " + reader.GetString(1));
                    Debug.WriteLine("Region : " + reader.GetInt32(2));
                    Debug.WriteLine("**********************************************" );
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("ERROR : " + ex.Message);
            }
            finally
            {
                reader.Close();
                sqlCon.Close();
            }
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