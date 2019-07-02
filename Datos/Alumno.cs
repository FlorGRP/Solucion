using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Alumno
    {
        //Metodo Agregar
        public void Agregar(Entidades.Alumno pAlumno)
        {
            string strConexion = @"Server=CPX-O6PQ19GS3AD\TRAINING; database=Techno;Integrated Security=true";
            string strSQL = @"insert Alumnos (dni,apellido,nombre) values(@dni,@apellido,@nombre)";

            SqlConnection objConexion = new SqlConnection();
            objConexion.ConnectionString = strConexion;

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strSQL;

            //Paramentros:Los parametros son propiedades
            objCommand.Parameters.AddWithValue("@dni", pAlumno.DNI);
            objCommand.Parameters.AddWithValue("@apellido", pAlumno.Apellido);
            objCommand.Parameters.AddWithValue("@nombre", pAlumno.Nombre);
  

            //Abro la conexion
            objConexion.Open();
            objCommand.ExecuteNonQuery();
            objConexion.Close();

        }

        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            string strConexion = @"Server=CPX-O6PQ19GS3AD\TRAINING; database=Techno;Integrated Security=true";
            string strSQL = "select* from Alumnos";

            SqlDataAdapter objDa = new SqlDataAdapter(strSQL, strConexion);
            objDa.Fill(dt);
            

            return dt;

        }

       
    }
}