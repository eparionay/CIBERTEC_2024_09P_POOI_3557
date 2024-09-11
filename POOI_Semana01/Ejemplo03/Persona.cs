using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    internal class Persona
    {
        public string nombres {  get; set; }
        public string apellidos { get; set; }
        public string documento { get; set; }
        public string tipo { get; set; }

        public Persona(string nombres, string apellidos, 
            string documento, string tipo)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.documento = documento;
            this.tipo = tipo;
        }


    }
}
