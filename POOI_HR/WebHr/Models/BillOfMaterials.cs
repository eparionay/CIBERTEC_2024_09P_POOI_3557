using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHr.Models
{
    public class BillOfMaterials
    {
        public int BillOfMaterialsID { get; set; }
        public int ProductAssemblyID { get; set; }
        public int ComponentID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UnitMeasureCode { get; set; }




    }
}