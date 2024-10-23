using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using POOI_Semana06.Models;
using System.Diagnostics;
namespace POOI_Semana06.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Inicio(int cboDepartamento=0, int cboTrabajo=0, int cboSupervisor=0)
        {
            Debug.WriteLine("Departamento :" + cboDepartamento);
            Debug.WriteLine("Trabajo :" + cboTrabajo);
            Debug.WriteLine("Supervisor :" + cboSupervisor);
            ViewBag.comboDepartamento = new SelectList(
                    listado().Where(x=>x.indicador.Equals("Departamento")),
                    "combo_id",
                    "combo_desc"
                );

            ViewBag.comboTrabajo = new SelectList(listado().Where(x=>x.indicador.Equals("Trabajo")), "combo_id", "combo_desc");
            ViewBag.comboSupervisor= new SelectList(listado().Where(x=>x.indicador.Equals("Supervisor")), "combo_id", "combo_desc");

            return View(listadoEmpleado(cboDepartamento, cboTrabajo, cboSupervisor));
        }


        public ActionResult Registro()
        {
            ViewBag.comboDepartamento = new SelectList(filtroCombo("Departamento"), "combo_id", "combo_desc");
            ViewBag.comboTrabajo = new SelectList(filtroCombo("Trabajo"), "combo_id", "combo_desc");
            ViewBag.comboSupervisor = new SelectList(filtroCombo("Supervisor"), "combo_id", "combo_desc");
            return View(new Empleado());
        }

        public List<ComboEmpleadoGeneral> filtroCombo(string indicador)
        {
            List<ComboEmpleadoGeneral> lista= listado().Where(x=> x.indicador.Equals(indicador)).ToList();
            return lista;
        }

        [HttpPost]
        public ActionResult Registro(Empleado emp)
        {
            int procesar = registrarEmpleado(emp);
            Debug.WriteLine("RPTA registrarEmpleado:  " + procesar);
            if (procesar > -1)
            {
                return RedirectToAction("Inicio");
            }

            ViewBag.comboDepartamento = new SelectList(filtroCombo("Departamento"), "combo_id", "combo_desc");
            ViewBag.comboTrabajo = new SelectList(filtroCombo("Trabajo"), "combo_id", "combo_desc");
            ViewBag.comboSupervisor = new SelectList(filtroCombo("Supervisor"), "combo_id", "combo_desc");

            return View(emp);
        }

        public int registrarEmpleado(Empleado emp)
        {
            int procesar = -1;
            try
            {

            
            using(SqlConnection con= new SqlConnection(ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_empleado_insertar", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@first_name", emp.firstname);
                cmd.Parameters.AddWithValue("@last_name", emp.lastname);
                cmd.Parameters.AddWithValue("@email", emp.email);
                cmd.Parameters.AddWithValue("@phone_number", emp.phone_number);
                cmd.Parameters.AddWithValue("@hire_date", emp.hire_date);
                cmd.Parameters.AddWithValue("@job_id", emp.job_id);
                cmd.Parameters.AddWithValue("@salary", emp.salary);
                cmd.Parameters.AddWithValue("@manager_id", emp.manager_id);
                cmd.Parameters.AddWithValue("@department_id", emp.department_id);
                procesar = cmd.ExecuteNonQuery();
            }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error : " + ex.ToString());
                Debug.WriteLine("Error : " + ex.Message);
            }
            return procesar;
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
        public List<ReporteEmpleado> listadoEmpleado(int departamento, int trabajo, int supervisor)
        {

            List<ReporteEmpleado> lista = new List<ReporteEmpleado>();
            using (SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString
                ))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_Listar", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@departamento", departamento);
                cmd.Parameters.AddWithValue("@trabajo", trabajo);
                cmd.Parameters.AddWithValue("@supervisor", supervisor);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    ReporteEmpleado objEmp;
                    while (reader.Read())
                    {
                        objEmp = new ReporteEmpleado();
                        objEmp.employee_id = reader.GetInt32(0);
                        objEmp.first_name = reader.GetString(1);
                        objEmp.last_name = reader.GetString(2);
                        objEmp.department_name = reader.GetString(3);
                        objEmp.street_address = reader.GetString(4);
                        objEmp.country_name = reader.GetString(5);
                        objEmp.region_name = reader.GetString(6);
                        objEmp.job_title= reader.GetString(7);
                        objEmp.max_salary = reader.GetDecimal(8);
                        objEmp.min_salary = reader.GetDecimal(9);
                        lista.Add(objEmp);
                    }
                }
            }
            return lista;
        }
    
    
    
    
    
    
    
    }
}