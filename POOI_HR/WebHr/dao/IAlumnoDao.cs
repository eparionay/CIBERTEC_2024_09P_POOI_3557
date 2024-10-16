using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHr.Models;


namespace WebHr.dao
{
    internal interface IAlumnoDao
    {
        List<Alumno> listaAlumno(string ape, string pais);

    }
}
