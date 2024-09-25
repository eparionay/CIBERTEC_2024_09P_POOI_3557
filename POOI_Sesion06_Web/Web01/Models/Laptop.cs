using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web01.Models
{
    public class Laptop
    {
        public int codigo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public double precioDolar { get; set; }

        public Laptop()
        {
            codigo = 0;
            marca = "";
            color = "";
            precioDolar = 0;
        }

        public Laptop(int codigo, string marca, string color, double precioDolar)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDolar = precioDolar;
        }

        public double getPrecioSoles()
        {
            return precioDolar * 3.84;
        }



    }
}