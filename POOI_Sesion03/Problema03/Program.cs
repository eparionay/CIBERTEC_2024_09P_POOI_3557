using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            StreamWriter objSw = new StreamWriter("C:/PRUEBA/archivo.txt",true);
            objSw.WriteLine("ESTO ES UN MENSAJE DE PRUEBA- EPY");
            objSw.Close();
            */
            string linea;
            StreamReader reader = new StreamReader("C:/PRUEBA/archivo.txt");

            linea = reader.ReadLine();

            while (linea !=null)
            {
                Console.WriteLine("..... : " + linea);
                linea = reader.ReadLine();
            }
            reader.Close();
            Console.ReadKey();



        }
    }
}
