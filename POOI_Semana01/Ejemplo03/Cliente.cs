using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    internal class Cliente: Persona
    {

        public string categoria { get; set; }
        public string codigo { get; set; }

        public Cliente(string nombres, string apellidos, 
            string documento, string tipo, 
            string categoria, string codigo) 
            : base(nombres, apellidos, documento, tipo)
        {
            this.categoria = categoria;
            this.codigo= codigo;

        }

        public void saludar()
        {
            Console.WriteLine("Soy el cliente : " + nombres);
        }


    }
}
