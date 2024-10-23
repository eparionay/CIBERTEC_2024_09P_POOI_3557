using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using POOI_Semana06.Models;
namespace POOI_Semana06.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Inicio(int cboDepartamento=0, int cboTrabajo=0, int cboSupervisor=0)
        {
            ViewBag.comboDepartamento = new SelectList(
                    listado().Where(x=>x.indicador.Equals("Departamento")),
                    "combo_id",
                    "combo_desc"
                );

            ViewBag.comboTrabajo = new SelectList(listado().Where(x=>x.indicador.Equals("Trabajo")), "combo_id", "combo_desc");
            ViewBag.comboSupervisor= new SelectList(listado().Where(x=>x.indicador.Equals("Supervisor")), "combo_id", "combo_desc");

            return View();
        }

        public List<ComboEmpleadoGeneral> listado()
        {
            List<ComboEmpleadoGeneral> lista=new List<ComboEmpleadoGeneral>();
            using (SqlConnection con= new SqlConnection(
                ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString
                ))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_form_combo_1", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader= cmd.ExecuteReader())
                {
                    ComboEmpleadoGeneral objCombo;
                    while (reader.Read())
                    {
                        objCombo = new ComboEmpleadoGeneral();
                        objCombo.indicador = reader.GetString(0);
                        objCombo.combo_id = reader.GetInt32(1);
                        objCombo.combo_desc = reader.GetString(2);
                        lista.Add(objCombo);
                    }
                }
            }
            return lista;
        }
    }
}