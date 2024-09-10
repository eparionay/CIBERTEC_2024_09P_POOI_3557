using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01_A
{
    internal class Estudiante
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public int edad { get; set; }

        public Estudiante()
        {
            this.codigo = 100;
            this.nombre = "Pedro";
            this.apellidoP = "Perez";
            this.edad = 10;
        }

        public string nombreCompleto(string nombre, string apellido)
        {
            return "Hola "+ nombre + " " + apellido;
        }

        public string nombreCompleto()
        {
            return "Hola ";
        }



    }
}
