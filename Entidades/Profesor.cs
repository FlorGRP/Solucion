using System;
using System.Data;
using System.Data.SqlClient;


namespace Entidades
{
    public class Profesor
    {
        //Atributos
        private int id;
        private string apellido;
        private string nombre;
        private string email;

        //Propiedades
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }



    }
}
