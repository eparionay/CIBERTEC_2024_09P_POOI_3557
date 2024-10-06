using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHr.Models;

namespace WebHr.dao
{
    internal interface IGeneralDao<T>
    {

        int operacionesEscritura(string indicador, T p);
        List<T> operacionesLectura(string indicador, string codigo);

    }
}
