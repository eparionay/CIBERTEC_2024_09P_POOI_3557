using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ejemplo 01 *********************");
            Estudiante objEstudiante = new Estudiante();
            objEstudiante.codigo = 101;
            Console.WriteLine("Codigo : " + objEstudiante.codigo);
            Console.WriteLine("Nombre : " + objEstudiante.nombre);

            Console.WriteLine("Ejemplo 02 *********************");
            Docente doc = new Docente();
            doc.codigo = 100;
            doc.nombre = "Juan";
            doc.horasTrabajadas = 5;
            doc.tarifa = 10;

            imprimir("Codigo : " + doc.codigo);
            imprimir("Sueldo Bruto : " + doc.calcularSueldoBruto());
            imprimir("Descuento : " + doc.calcularDescuento());
            imprimir("Sueldo Neto : " + doc.calcularSueldoNeto());
            Console.WriteLine("Ejemplo 03 *********************");

            Alumno alumno = new Alumno();
            alumno.nombre = "Erick";
            alumno.nombreCompleto();


            Console.ReadKey();
        }

        public static void imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
