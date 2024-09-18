using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaArchivo = ConfigurationManager.AppSettings["ruta_log"].ToString();
            string correo = ConfigurationManager.AppSettings["correo"].ToString();
            string pwd = ConfigurationManager.AppSettings["correoPwd"].ToString();


            Console.WriteLine(rutaArchivo);
            Console.WriteLine(correo);
            Console.WriteLine(pwd);


            Console.ReadKey();
            StreamWriter escritor = null ;

            try
            {
                escritor = new StreamWriter(rutaArchivo, true);
                escritor.WriteLine("mensaje 1");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                escritor.Close();
            }
            Console.ReadKey();

        }
    }
}
