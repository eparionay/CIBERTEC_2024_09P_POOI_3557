using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaInicio = DateTime.Now;
            Console.WriteLine("fechaInicio :" + fechaInicio);

            Stopwatch observador= new Stopwatch();
            observador.Start();

            List<Empleado> lista = new List<Empleado>();
            Empleado emp01 = new Empleado(1,"Juana", "Fuentes", 700);
            lista.Add(emp01);

            lista.Add(new Empleado()
            {
                codigo=2, nombre="Rosa", apellido="Carmely", sueldo= 650
            });

            lista.Add(new Empleado(3,"Erick","P", 1000));


            foreach (var x in lista)
            {
                Console.WriteLine(x.codigo + "-" + x.nombre);
            }
            Console.WriteLine("************************");
            for(int i=0; i< lista.Count; i++)
            {
                Console.WriteLine(lista[i].nombre);
            }

            for (int i=0; i< 1; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
           
            observador.Stop();
            DateTime fechaFin = DateTime.Now;
            Console.WriteLine("fechaFin :" + fechaFin);
            Console.WriteLine(
                fechaFin.ToString("yyyy-MM-dd hh:mm:ss.fff") +"----" +
                fechaFin.ToString("yyyy-MM-dd HH:mm:ss.fff")
                );

            Console.WriteLine("Tiempo :" + observador.Elapsed);


            Console.ReadKey();


        }
    }
}
