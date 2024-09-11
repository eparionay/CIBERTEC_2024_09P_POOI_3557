using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Cliente cliente = new Cliente();
            cliente.nombres = "Juan";
            cliente.saludar();

            Empleado empleado = new Empleado();
            empleado.nombres = "Pedro";
            empleado.saludar();
            */

            Persona persona = new Persona("Juana", "Sifuentes", "789203001", "0");
            Persona cliente = new Cliente("Juan", "Reynoso", "789203002", "1", "VIP", "CLI100");
            Persona empleado = new Empleado("Rosa","Perez","789203003","2","COMPLETO",2500);


            imprimir(persona.nombres + "-"+persona.apellidos);
            imprimir(cliente.nombres + "-" + cliente.apellidos);
            imprimir(empleado.nombres + "-" + empleado.apellidos);





            Console.ReadKey();

        }

        public static void imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

    }
}
