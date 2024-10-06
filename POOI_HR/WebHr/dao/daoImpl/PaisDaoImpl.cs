using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WebHr.Models;

namespace WebHr.dao.daoImpl
{
    public class PaisDaoImpl : IGeneralDao<Pais>
    {


        public int operacionesEscritura(string indicador, Pais p)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int procesar = -1;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString);
                con.Open();
                cmd = new SqlCommand("USP_COUNTRIES_CRUD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@indicador", indicador);
                cmd.Parameters.AddWithValue("@country_id", p.country_id);
                cmd.Parameters.AddWithValue("@country_name", p.country_name);
                cmd.Parameters.AddWithValue("@region_id", p.region_id);
                procesar = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("operacionesEscritura()- Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return procesar;
        }

        public List<Pais> operacionesLectura(string indicador, string codigo)
        {
            List<Pais> lista = new List<Pais>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString);
                con.Open();
                cmd = new SqlCommand("USP_COUNTRIES_CRUD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@indicador", indicador);
                cmd.Parameters.AddWithValue("@country_id", codigo);
                cmd.Parameters.AddWithValue("@country_name", "");
                cmd.Parameters.AddWithValue("@region_id", 0);
                reader = cmd.ExecuteReader();
                Pais objPais;
                while (reader.Read())
                {
                    objPais = new Pais()
                    {
                        country_id = reader.GetString(0),
                        country_name = reader.GetString(1),
                        region_id = reader.GetInt32(2)
                    };
                    lista.Add(objPais);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("operacionesLectura() - Error : " + ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }
            return lista;
        }

     
    }
}