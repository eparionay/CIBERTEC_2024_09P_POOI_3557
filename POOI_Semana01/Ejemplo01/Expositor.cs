using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    internal class Expositor
    {
        public int codigo {  get; set; }
        public string nombre { get; set; }  
        public int horas { get; set; }
        public double tarifa { get; set; }


        public double getSueldoBruto()
        {
            return horas * tarifa;
        }

        public double getDescuentoAFP()
        {
            return getSueldoBruto() * 0.1;
        }

        public double getDescuentoEPS()
        {
            return getSueldoBruto() * 0.05;
        }

        public double getSueldoNeto()
        {
            return getSueldoBruto() - 
                getDescuentoAFP() - getDescuentoEPS();
        }





    }
}
