using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Empleado
    {
       

        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public double sueldo { get; set; }

        public Empleado()
        {

        }

        public Empleado(int codigo, string nombre, string apellido, double sueldo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
        }
    }
}
