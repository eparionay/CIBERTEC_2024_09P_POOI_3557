using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Estudiante> lista = new List<Estudiante>();
            lista.Add(new Estudiante(1, "Juana", "Reyes", 20));
            lista.Add(new Estudiante(2, "Juan", "Fuentes", 15));
            lista.Add(new Estudiante(3, "Ana", "Rosst", 3));
            lista.Add(new Estudiante(4, "Luisa", "Aquije", 18));
            lista.Add(new Estudiante(5, "Fernanda", "Perez", 35));
            lista.Add(new Estudiante(6, "Fernando", "Domingo", 10));
            imprimir(lista);
            /*
            Console.WriteLine("******************");
            List<Estudiante> lista1 = lista.OrderBy(x => x.edad).ToList();
            imprimir(lista1);
            Console.WriteLine("******************");
            List<Estudiante> lista2 = lista.OrderByDescending(x => x.edad).ToList();
            imprimir(lista2);
            Console.WriteLine("******************");
            */
            Console.WriteLine("******************");
            lista.RemoveAll(x=> x.codigo == 3);
            imprimir(lista);







            Console.ReadKey();
        }

        public static void imprimir(List<Estudiante> lista)
        {
            foreach(var x in lista)
            {
                Console.WriteLine($"Id: {x.codigo} - N: {x.nombre}- A: {x.apellido} - E: {x.edad}");
            }
        }




    }
}
