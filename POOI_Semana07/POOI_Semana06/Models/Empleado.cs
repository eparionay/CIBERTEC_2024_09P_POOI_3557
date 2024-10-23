using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOI_Semana06.Models
{
    public class Empleado
    {
        public int employee_id {  get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email {  get; set; }
        public string phone_number {  get; set; }
        public DateTime hire_date { get; set; }
        public int job_id { get; set; }
        public decimal salary { get; set; }
        public int manager_id { get; set; }
        public int department_id { get; set; }

        public Empleado()
        {
            employee_id = 0;
            hire_date = DateTime.Now;
            salary = 0;
        }



    }
}