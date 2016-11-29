using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EjemploStateServer.Models;

namespace EjemploStateServer
{
    public partial class SesionCompartida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Mostrarresultado();
            MostrarAppDomain();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text) &&
                string.IsNullOrEmpty(txtNombre.Text))
                return;

            Persona persona = new Persona();
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;

            SesionPersona = persona;
            Mostrarresultado();
        }

        private void Mostrarresultado()
        {
            if (SesionPersona != null)
            {
                lblResultado.Text = string.Format("{0} {1}", SesionPersona.Nombre, SesionPersona.Apellido);
            }
            else
            {
                lblResultado.Text = "No existe sesión.";
            }
        }

        public Persona SesionPersona
        {
            get
            {
                return Session["Persona"] as Persona;
            }

            set
            {
                Session["Persona"] = value;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            SesionPersona = null;
            txtNombre.Text = String.Empty;
            txtApellido.Text = string.Empty;
            Mostrarresultado();
        }

        protected void btnMostrarResultado_Click(object sender, EventArgs e)
        {
            Mostrarresultado();
        }

        private void MostrarAppDomain()
        {
            FieldInfo runtimeInfo = typeof(HttpRuntime).GetField("_theRuntime", BindingFlags.Static | BindingFlags.NonPublic);
            HttpRuntime theRuntime = (HttpRuntime)runtimeInfo.GetValue(null);
            FieldInfo appNameInfo = typeof(HttpRuntime).GetField("_appDomainAppId", BindingFlags.Instance | BindingFlags.NonPublic);
            lblAppDomain.Text = string.Format("App Domain: {0}", (String) appNameInfo.GetValue(theRuntime));
        }

    }
}