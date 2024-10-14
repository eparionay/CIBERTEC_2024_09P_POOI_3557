using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHr.Models;
namespace WebHr.dao
{
    internal interface IRegionDao
    {
        int operacionesEscritura(string indicador, Region region);
        List<Region> operacionesLectura(string indicador, int codigo);

    }
}
