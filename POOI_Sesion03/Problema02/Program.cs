using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno objAlumno = new Alumno();
            objAlumno.nombre = "Juana";
            objAlumno.apellido = "Reyes";
            objAlumno.codigo = "100";
            string cadenajson = JsonConvert.SerializeObject(objAlumno);
            Console.WriteLine("El json generado es : "+ cadenajson);
            Console.WriteLine("***********************************************");

            Alumno alu = JsonConvert.DeserializeObject<Alumno>(cadenajson);
            Console.WriteLine("Codigo :" +alu.codigo);
            Console.WriteLine("Nombre :" + alu.nombre);
            Console.WriteLine("Apellido :" + alu.apellido);

            Console.ReadKey();

        }
    }
}
