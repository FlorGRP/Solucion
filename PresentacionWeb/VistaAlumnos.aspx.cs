﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class VistaAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Logica.Alumno objLogica = new Logica.Alumno();
            GVAlumnos.DataSource = objLogica.TraerTodos();
            GVAlumnos.DataBind();

        }
    }
}