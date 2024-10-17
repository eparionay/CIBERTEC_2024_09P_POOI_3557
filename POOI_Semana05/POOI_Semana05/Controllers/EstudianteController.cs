using POOI_Semana05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using POOI_Semana05.utils;
using System.Diagnostics;

namespace POOI_Semana05.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index(string codigo="", 
            string apellido="", int cboRegion = 0, int cboDepartamento=0, int cboTrabajo=0)
        {

            List<ComboProcedimiento> listaCombo = listadoGeneralProcedimiento();

            foreach (ComboProcedimiento  x in listaCombo)
            {
                Debug.WriteLine(x.identificador+"-"+x.comboName+"-"+ x.comboId);
            }

            List<ComboProcedimiento> listaRegion = listaCombo.Where(x=> x.identificador.Equals("COMBO_REGION")).ToList();
            List<ComboProcedimiento> listaDepart = listaCombo.Where(x => x.identificador.Equals("COMBO_DEPARTAMENTO")).ToList();
            List<ComboProcedimiento> listaTrabajo = listaCombo.Where(x => x.identificador.Equals("COMBO_TRABAJO")).ToList();



            ViewBag.comboRegiones = new SelectList(listaRegion, "comboId", "comboName");
            ViewBag.comboDepartamentos = new SelectList(listaDepart, "comboId", "comboName");
            ViewBag.comboTrabajo = new SelectList(listaTrabajo, "comboId", "comboName");


            List<Estudiante> lista = new List<Estudiante>();
            lista.Add(new Estudiante()
            {
                codigo=100, nombre= "Angelica", apellido= "Ramos"
            });
            lista.Add(new Estudiante()
            {
                codigo= 101, nombre= "Juana",  apellido= "Fuentes"
            });
            /*
            ViewBag.comboRegiones = new SelectList(listadoGeneral(AppGeneralDatos.COMBO_REGION), "comboId", "comboName");
            ViewBag.comboDepartamentos = new SelectList(listadoGeneral(AppGeneralDatos.COMBO_DEPARTAMENTO), "comboId", "comboName");
            ViewBag.comboTrabajo = new SelectList(listadoGeneral(AppGeneralDatos.COMBO_TRABAJO), "comboId", "comboName");
            */

            return View(lista);
        }

        public List<ComboGeneral> listadoGeneral(string instruccionSQL)
        {
            List<ComboGeneral> listado = new List<ComboGeneral>();
            string cadena_con = ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString;
            // string query_str = "select region_name, region_id from regions";
            using (SqlConnection con = new SqlConnection(cadena_con)) 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(instruccionSQL, con);
                cmd.CommandType = System.Data.CommandType.Text;
                ComboGeneral objGeneral;
                int posNombre, posId;
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objGeneral = new ComboGeneral();
                        posId = reader.GetOrdinal("combo_id");
                        posNombre = reader.GetOrdinal("combo_name");
                        objGeneral.comboId = reader.GetInt32(posId);
                        objGeneral.comboName = reader.GetString(posNombre);
                        listado.Add(objGeneral);
                    }
                }
            }
            return listado;
        }

        public List<ComboProcedimiento> listadoGeneralProcedimiento()
        {
            List<ComboProcedimiento> listado = new List<ComboProcedimiento>();
            string cadena_con = ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cadena_con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_formulario_combo_AllInOne", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                ComboProcedimiento objGeneral;
                int posIdent,posNombre, posId;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objGeneral = new ComboProcedimiento();
                        posIdent = reader.GetOrdinal("combo_identificador");
                        posId = reader.GetOrdinal("combo_id");
                        posNombre = reader.GetOrdinal("combo_name");
                        objGeneral.identificador= reader.GetString(posIdent);
                        objGeneral.comboId = reader.GetInt32(posId);
                        objGeneral.comboName = reader.GetString(posNombre);
                        listado.Add(objGeneral);
                    }
                }
            }
            return listado;
        }


     

    }
}