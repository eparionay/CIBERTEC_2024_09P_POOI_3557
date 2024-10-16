using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHr.dao;
using WebHr.dao.daoImpl;
using WebHr.Models;

namespace WebHr.servicio
{
    public class ServicioAlumno
    {
        public List<Alumno> listaAlumno(string apellido, string pais)
        {
            IAlumnoDao dao = new AlumnoDaoImpl();
            return dao.listaAlumno(apellido, pais);
        }
    }
}