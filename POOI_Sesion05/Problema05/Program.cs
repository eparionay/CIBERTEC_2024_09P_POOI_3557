using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> lista = new List<Empleado>();
            lista.Add(new Empleado(1, "Juana", "Adrianzen", 60));
            lista.Add(new Empleado(2, "Rosa", "Reyes", 33));
            lista.Add(new Empleado(3, "Maria", "Romina", 20));
            lista.Add(new Empleado(4, "Adriana", "Perez", 30));
            lista.Add(new Empleado(5, "Sandy", "Gonzales", 40));
            lista.Add(new Empleado(6, "Cristina", "Palomino", 50));
            imprimir(lista);
            Console.WriteLine("**************************");
            Empleado objEmpleado = lista.Where(x => x.codigo == 1).First();
            Console.WriteLine(objEmpleado.codigo);
            Console.WriteLine(objEmpleado.nombre);
            Console.WriteLine("**************************");
            List<Empleado> listaEdad = lista.Where(x => x.edad > 35).ToList();
            imprimir(listaEdad);
            Console.WriteLine("**************************");
            int indiceBusqueda = lista.FindIndex(x=>x.codigo==3);
            Console.WriteLine("Posicion : " + indiceBusqueda);
            Console.WriteLine("**************************");
            //lista.RemoveAt(indiceBusqueda);
            imprimir(lista);
            Console.ReadKey();
        }
        public static void imprimir(List<Empleado> lista)
        {
            foreach (var x in lista)
            {
                Console.WriteLine(x.nombre + "-" + x.apellido + "-Edad:" + x.edad + "-Id: " + x.codigo);
            }
        }


    }
}
