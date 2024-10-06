using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHr.dao;
using WebHr.dao.daoImpl;
using WebHr.Models;

namespace WebHr.servicio
{
    public class ServicioPais
    {
        public List<Pais> operacionesLectura(string indicador, string codigo)
        {
            IGeneralDao<Pais> dao = new PaisDaoImpl();
            return dao.operacionesLectura(indicador, codigo);
        }

        public int operacionesEscritura(string indicador, Pais p)
        {
            IGeneralDao<Pais> dao = new PaisDaoImpl();
            return dao.operacionesEscritura(indicador, p);
        }


    }
}