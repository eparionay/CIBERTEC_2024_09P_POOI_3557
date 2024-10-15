using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHr.Models;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
     


namespace WebHr.dao.daoImpl
{
    public class AlumnoDaoImpl : IAlumnoDao
    {
        public List<Alumno> listaAlumno()
        {
            List < Alumno > lista= new List<Alumno> ();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string str_conexion = ConfigurationManager.ConnectionStrings["cnx_pooi_semana06"].ConnectionString;
            try
            {
                con= new SqlConnection(str_conexion);
                con.Open();
                cmd = new SqlCommand("usp_alumno_consulta", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();
                Alumno alu;
                int poscod, posnom, posape, pospa, posdir;
                while (dr.Read())
                {
                    alu = new Alumno();
                    poscod = dr.GetOrdinal("codigo");
                    posnom = dr.GetOrdinal("nombre");
                    posape = dr.GetOrdinal("apellido");
                    pospa = dr.GetOrdinal("pais");
                    posdir = dr.GetOrdinal("direccion");

                    alu.codigo = dr.GetInt32(poscod);
                    alu.nombre= dr.GetString(posnom);
                    alu.apellido= dr.GetString(posape);
                    alu.pais=dr.GetString(pospa);
                    alu.direccion= dr.GetString(posdir);
                    lista.Add(alu);


                    
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error1 : " + ex.Message);
                Debug.WriteLine("Error2 : " + ex.ToString());
            }
            finally
            {
                dr.Close ();
                con.Close();
            }

            return lista;
        }


    }
}