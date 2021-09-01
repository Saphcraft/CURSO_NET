using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPInyeccionSQL
{
    public partial class consulta : System.Web.UI.Page
    {
        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT nombre,clave,mail FROM usuarios WHERE nombre='" + this.txtNombreUsuario.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read()) { lblConfirmacion.Text = "Clave: " + registro["clave"] + "<br>" + "Mail: " + registro["mail"]; }
            else { lblConfirmacion.Text = "No existe un usuario con dicho nombre"; }
            conexion.Close();
            txtNombreUsuario.Text = "";
        }

       
    }
}