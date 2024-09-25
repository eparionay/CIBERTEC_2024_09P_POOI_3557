using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POOI_Sesion05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:/log/archivoa.txt";

            try
            {
                if (File.Exists(ruta))
                {
                    Console.WriteLine("El archivo existe");
                }
                else
                {
                    Console.WriteLine("El archivo no existe");
                    FileStream archivo = File.Create(ruta);
                    archivo.Close();
                    Console.WriteLine("Se genero el archivo .....");
                }
                Thread.Sleep(2000);
                DateTime fecha = DateTime.Now;
                string formatoFecha = fecha.ToString("yyyyMMddHHmmss");
                //string identificadorGlobal= Guid.NewGuid().ToString();
                string rutaDestino = "C:/log/Enviados/archivoa_"+ formatoFecha + ".txt";
                string rutaDestinoBackup = "C:/log/Backup/archivoa_" + formatoFecha + ".txt";
                Console.WriteLine("Se esta copiando el archivo");
                File.Copy(ruta, rutaDestinoBackup);

                Console.WriteLine("Se esta moviendo el archivo");
                File.Move(ruta, rutaDestino);

                if (File.Exists(ruta))
                {
                    File.Delete(ruta);
                    Console.WriteLine("Se elimina el archivo ......");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
