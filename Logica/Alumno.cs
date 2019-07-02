using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Alumno
    {
        //Metodos

        public void Agregar(Entidades.Alumno pAlumno)
        {
            Datos.Alumno objAlumno = new Datos.Alumno();
            objAlumno.Agregar(pAlumno);
        }

        public DataTable TraerTodos()
        {
            Datos.Alumno objDatos = new Datos.Alumno();
            return objDatos.TraerTodos();
        }
    }
}
