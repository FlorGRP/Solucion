using System;
using System.Data;
using System.Data.SqlClient;


namespace PresentacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Alumno objEntidadAlumno = new Entidades.Alumno();

            Console.Write("Ingrese Apellido: ");
            objEntidadAlumno.Apellido = Console.ReadLine();

            Console.Write("Ingrese Nombre: ");
            objEntidadProfesor.Nombre = Console.ReadLine();

            Console.Write("Ingrese Email: ");
            objEntidadProfesor.Email = Console.ReadLine();

            Logica.Profesor objLogicaProfesor = new Logica.Profesor();
            objLogicaProfesor.Agregar(objEntidadProfesor);

            Console.WriteLine("Profesor agregado exitosamente");

            Console.ReadKey();




        }
    }
}
