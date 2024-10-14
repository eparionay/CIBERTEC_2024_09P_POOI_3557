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
    public class RegionDaoImpl : IRegionDao
    {
        public int operacionesEscritura(string indicador, Region p)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int procesar = -1;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString);
                con.Open();
                cmd = new SqlCommand("usp_region_crud", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@indicador", indicador);
                cmd.Parameters.AddWithValue("@region_id", p.region_id);
                cmd.Parameters.AddWithValue("@region_name", p.region_name);
                procesar = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("operacionesEscritura-Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return procesar;
        }

        public List<Region> operacionesLectura(string indicador, int codigo)
        {
            List<Region> lista = new List<Region>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString);
                con.Open();
                cmd = new SqlCommand("usp_region_crud", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@indicador", indicador);
                cmd.Parameters.AddWithValue("@region_id", codigo);
                cmd.Parameters.AddWithValue("@region_name", "");

                reader = cmd.ExecuteReader();
                Region reg;
                int posRegionId, posRegionName;
                while (reader.Read())
                {
                    reg = new Region();
                    posRegionId = reader.GetOrdinal("region_id");
                    posRegionName = reader.GetOrdinal("region_name");
                    reg.region_id = reader.GetInt32(posRegionId);
                    reg.region_name = reader.GetString(posRegionName);
                    lista.Add(reg);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("operacionesLectura-Error:" + ex.Message);
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