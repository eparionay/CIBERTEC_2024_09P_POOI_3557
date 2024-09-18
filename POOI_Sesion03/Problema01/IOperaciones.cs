using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal interface IOperaciones
    {
        double suma(double num1, double num2);
        double resta(double num1, double num2);
        double multiplicacion(double num1, 
            double num2);
        double dividir(double num1, double num2);
        double residuo(double num1, double num2);




    }
}
