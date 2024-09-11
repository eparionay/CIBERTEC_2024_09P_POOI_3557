using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    internal class Program
    {

        private static readonly ILog LOG = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            LOG.Info("INICIO DE PROGRAMA ******************************************");
            int numerador = 10;
            int denominador = 0;

            try
            {
                int resultado = numerador / denominador;
                LOG.Info("Resultado : " + resultado);   
            }
            catch (Exception ex)
            {
                LOG.Error("Error : " + ex.ToString());
                LOG.Error("Error : " + ex.TargetSite);
                LOG.Error("Error : " + ex.Message);
            }
            finally
            {

            }
            LOG.Info("FIN DEL PROGRAMA ******************************************");

            Console.ReadKey();
           
        }
    }
}
