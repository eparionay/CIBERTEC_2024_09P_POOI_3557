﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Estudiante
    {
        public int codigo { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }



        public Estudiante(int codigo, string nombre, string apellido, int edad)

        {

            this.codigo = codigo;

            this.nombre = nombre;

            this.apellido = apellido;

            this.edad = edad;

        }



        public Estudiante() { }



    }
}
