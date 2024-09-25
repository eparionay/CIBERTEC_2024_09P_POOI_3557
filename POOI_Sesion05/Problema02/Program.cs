using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ruta directorio
            string ruta = "C:/log/NuevoDirectorio";
            //Validar si el directorio existe
            if (Directory.Exists(ruta))
            {
                Console.WriteLine("El directorio existe");
            }
            else
            {
                //Crear directorio
                Directory.CreateDirectory(ruta);
                Console.WriteLine("Se creo el directorio .....");
                // Crear Subdirectorios
                DirectoryInfo dirInfo = new DirectoryInfo(ruta);
                dirInfo.CreateSubdirectory("Carpeta1");
                Console.WriteLine("Se creo el subdirectorio Carpeta1 .....");
                dirInfo.CreateSubdirectory("Carpeta2");
                Console.WriteLine("Se creo el subdirectorio Carpeta2.....");
                dirInfo.CreateSubdirectory("Carpeta3");
                Console.WriteLine("Se creo el subdirectorio Carpeta3.....");
            }

            Console.ReadKey();
        }
    }
}
