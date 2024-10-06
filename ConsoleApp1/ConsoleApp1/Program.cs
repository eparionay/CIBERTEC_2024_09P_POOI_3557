using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            if (File.Exists("C:/lodsdsgsdd/arcvo.txt"))
            {
                StreamWriter escritor = new StreamWriter("C:/lodsdsgs/arcvo.txt");
                escritor.WriteLine("asd");
                escritor.Close();
            }
            else
            {
                Directory.CreateDirectory("C:/loga") ;
                DirectoryInfo info = new DirectoryInfo("C:/loga");
                info.CreateSubdirectory("as");
            }
            */
            DirectoryInfo info = new DirectoryInfo("c:/loga");
            DirectoryInfo []  h = info.GetDirectories();

            Console.WriteLine(h.Length);

            foreach(DirectoryInfo d in h)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("Elemento : " + d.FullName);
                DirectoryInfo x = new DirectoryInfo(d.FullName);
                Console.WriteLine("Carpeta : " + x.FullName);
                FileInfo [] archivos =x.GetFiles();
                foreach(FileInfo archivo in archivos)
                {
                    Console.WriteLine("Ubicacion : " + archivo.FullName);
                    Console.WriteLine("Extension: " + archivo.Extension);
                    Console.WriteLine("Tamano : " + archivo.Length);
                    Console.WriteLine("Fecha Creacion : " + archivo.CreationTime);
                    Console.WriteLine("Nombre : " + archivo.Name);
                    Console.WriteLine(archivo.IsReadOnly); 
                }
                Console.WriteLine("**************************");
            }




            Console.ReadKey();


        }
    }
}
