using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOI_Semana06.Models
{
    public class ReporteEmpleado
    {
        public int employee_id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string job_title { get; set; }

        public decimal min_salary { get; set; }

        public decimal max_salary { get; set; }

        public string department_name { get; set; }

        public string street_address { get; set; }

        public string country_name { get; set; }

        public string region_name { get; set; }

    }
}
