using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Expositor expo = new Expositor();
            expo.tarifa = 10;
            expo.horas = 4;

            imprimir("Hola Juan");
            imprimir("Horas "+ expo.horas);
            
            imprimir("Sueldo Bruto  : " + expo.getSueldoBruto());
            imprimir("Descuento AFP : " + expo.getDescuentoAFP());
           

            
            Console.ReadKey();
        }
        public static void imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }


    }
}
