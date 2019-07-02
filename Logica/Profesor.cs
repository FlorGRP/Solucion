using System;
using System.Data;
using System.Data.SqlClient;


namespace Logica
{
    public class Profesor
    {
        //Metodos
        
        public void Agregar (Entidades.Profesor pProfesor)
        {
            Datos.Profesor objProfesor = new Datos.Profesor();
            objProfesor.Agregar(pProfesor);
        }
       
    
    }
}
