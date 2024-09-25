using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo("C:/log");
            //1er paso obtener los directorios
            DirectoryInfo [] dir_arreglo =dir.GetDirectories();

            foreach(DirectoryInfo dir_ in dir_arreglo)
            {
                Console.WriteLine("************** Inicio ");
                Console.WriteLine("Nombre Directorio : " + dir_.Name);
                Console.WriteLine("Ruta Directorio : " + dir_.FullName);
                FileInfo[] archivo_arreglo = dir_.GetFiles();
                Console.WriteLine("****+ INI ARCHIVOS *****");
                foreach (FileInfo arc in archivo_arreglo)
                {
                    Console.WriteLine("Nombre Archivo : " + arc.Name);
                }
                Console.WriteLine("****+ FIN ARCHIVOS *****");

                Console.WriteLine("*******************************");
            }
            Console.ReadKey();
        }
    }
}
