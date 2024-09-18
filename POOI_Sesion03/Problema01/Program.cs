using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IOperaciones objOperaciones = new ServicioOperaciones();
            double numero1 = 10;
            double numero2= 5;

            Console.WriteLine("Suma : " + objOperaciones.suma(numero1,numero2));
            Console.WriteLine("Resta : " + objOperaciones.resta(numero1, numero2));



            Console.ReadKey();

        }
    }
}
