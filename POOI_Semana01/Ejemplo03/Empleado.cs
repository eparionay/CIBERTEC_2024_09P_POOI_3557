using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    internal class Empleado: Persona
    {
        public Empleado(string nombres, string apellidos, string documento, string tipo,
            string tipoContrato, double sueldo) : 
            base(nombres, apellidos, documento, tipo)
        {
            this.tipoContrato = tipoContrato;
            this.sueldo = sueldo;
        }

        public string tipoContrato { get; set; }
        public double sueldo { get; set; }  





        public void saludar()
        {
            Console.WriteLine("Soy el empleado : " + nombres);
        }

    }
}
