using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHr.dao;
using WebHr.dao.daoImpl;
using WebHr.Models;
namespace WebHr.servicio
{
    public class ServicioRegion
    {
        public int operacionesEscritura(string indicador, Region region)
        {
            IRegionDao dao = new RegionDaoImpl();
            return dao.operacionesEscritura(indicador, region);
        }
        public List<Region> operacionesLectura(string indicador, int codigo)
        {
            IRegionDao dao = new RegionDaoImpl();
            return dao.operacionesLectura(indicador, codigo);
        }
    }
}