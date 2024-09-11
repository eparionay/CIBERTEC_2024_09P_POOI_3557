using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Docente doc0 = new Docente();
            Console.WriteLine(doc0.codigo);
            Console.WriteLine(doc0.nombre);
            doc0.saludar();

            Console.WriteLine("***************");

            Docente doc = new Docente(100);
            Console.WriteLine(doc.codigo);
            

            Console.ReadKey();



        }
    }
}
