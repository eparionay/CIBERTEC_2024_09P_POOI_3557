using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01_A
{
    internal class Docente
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horasTrabajadas { get; set; }
        public double tarifa { get; set; }


    


        public double calcularSueldoBruto()
        {
            return horasTrabajadas*tarifa;
        }

        public double calcularDescuento()
        {
            double sueldo= calcularSueldoBruto();
            if (sueldo < 4500)
            {
                return sueldo * 0.12;
            }else if (sueldo< 6500)
            {
                return sueldo * 0.14;
            }
            else
            {
                return sueldo * 0.16;
            }
        }

        public double calcularSueldoNeto()
        {
            return calcularSueldoBruto() - 
                calcularDescuento();
        }



    }
}
