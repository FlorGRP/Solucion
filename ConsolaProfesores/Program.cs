using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaProfesores
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Profesor objEntidadProfesor = new Entidades.Profesor();

            Console.Write("Ingrese Apellido: ");
            objEntidadProfesor.Apellido = Console.ReadLine();

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
