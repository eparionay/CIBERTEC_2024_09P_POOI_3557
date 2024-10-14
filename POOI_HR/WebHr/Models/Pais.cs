using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebHr.Models
{
    public class Pais
    {
        [DisplayName("Codigo Pais")]
        [Required(ErrorMessage ="Codigo de Pais se debe ingresar")]
        [MinLength(2,ErrorMessage ="Codigo de pais debe ser 2 caracteres")]
        [MaxLength(2,ErrorMessage ="Codigo de pais debe ser 2 caracteres")]
        [RegularExpression("([a-zA-z]+)",ErrorMessage ="El texto ingresado no es valido")]

        public string country_id { get; set; }
        [DisplayName("Nombre")]
        [MaxLength(40, ErrorMessage ="Nombre de Pais debe ser 40 caracteres")]
        [Required(ErrorMessage ="Nombre de Pais se debe ingresar")]

        public string country_name { get; set; }
        [DisplayName("Region")]
        public int region_id { get; set; }

    }
}