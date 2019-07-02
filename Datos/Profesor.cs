using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Profesor
    {
        //Metodo Agregar
        public void Agregar( Entidades.Profesor pProfesor)
        {
            string strConexion = @"Server=CPX-O6PQ19GS3AD\TRAINING; database=Techno;Integrated Security=true";
            string strSQL = @"insert Profesores(id,apellido,nombre,email) values(@id,@apellido,@nombre,@email)";

            SqlConnection objConexion = new SqlConnection();
            objConexion.ConnectionString = strConexion;

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strSQL;

            //Paramentros:Los parametros son propiedades
            objCommand.Parameters.AddWithValue("@id", pProfesor.ID);
            objCommand.Parameters.AddWithValue("@apellido", pProfesor.Apellido);
            objCommand.Parameters.AddWithValue("@nombre", pProfesor.Nombre);
            objCommand.Parameters.AddWithValue("@email", pProfesor.Email);

            //Abro la conexion
            objConexion.Open();
            objCommand.ExecuteNonQuery();
            objConexion.Close();




        }
    }
}
