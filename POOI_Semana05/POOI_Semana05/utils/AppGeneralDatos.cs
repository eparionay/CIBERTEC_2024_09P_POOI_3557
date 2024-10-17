using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOI_Semana05.utils
{
    public class AppGeneralDatos
    {

        public const string COMBO_REGION = "select region_id as combo_id, region_name as combo_name from regions";
        public const string COMBO_DEPARTAMENTO = "select department_id as combo_id, department_name as combo_name from departments";
        public const string COMBO_TRABAJO = "select job_id as combo_id, job_title as combo_name from jobs ";

    }
}