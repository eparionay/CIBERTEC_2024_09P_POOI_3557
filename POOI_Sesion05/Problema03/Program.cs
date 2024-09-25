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
            FileInfo fileInfo = new FileInfo("C:/log/prueba.txt");

            Console.WriteLine("Ruta : " + fileInfo.FullName);
            Console.WriteLine("Nombre : " + fileInfo.Name);
            Console.WriteLine("Extension : " + fileInfo.Extension);
            Console.WriteLine("Fecha Creacion : " + fileInfo.CreationTime);
            Console.WriteLine("Fecha Modificacion : " + fileInfo.LastWriteTime);
            Console.WriteLine("Ultimo acceso : " + fileInfo.LastAccessTime);
            Console.WriteLine("Tamano : " + fileInfo.Length);
            Console.WriteLine("Solo Lectura(T)(F) : " + fileInfo.IsReadOnly);

            Console.ReadKey();
        }
    }
}
