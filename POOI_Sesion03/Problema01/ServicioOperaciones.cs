using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class ServicioOperaciones : IOperaciones
    {
        public double dividir(double num1, double num2)
        {
            return num1 / num2;
        }

        public double multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        public double residuo(double num1, double num2)
        {
            return num1 % num2;
        }

        public double resta(double num1, double num2)
        {
            return num1 - num2;
        }

        public double suma(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
