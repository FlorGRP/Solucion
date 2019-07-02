using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class AltaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            Entidades.Alumno objEntidad = new Entidades.Alumno();
            Logica.Alumno objLogica = new Logica.Alumno();

            objEntidad.DNI = Convert.ToInt32(TxtDNI.Text);
            objEntidad.Apellido = TxtApellido.Text;
            objEntidad.Nombre = TxtNombre.Text;

            objLogica.Agregar(objEntidad);
            LblMensaje.Text = "Alumno Agregado";
        }
    }
}