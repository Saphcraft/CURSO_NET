using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPInyeccionSQL
{
    public partial class modificacion : System.Web.UI.Page
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
            if (registro.Read()) { lblConfirmacion.Text = "Clave: " + registro["clave"] + "<br>" + "Mail: " + registro["mail"];
                txtClave.Text = registro["clave"].ToString();
                txtEmail.Text = registro["mail"].ToString();
            }
            else { lblConfirmacion.Text = "No existe un usuario con dicho nombre"; }
            conexion.Close();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE usuarios SET " + "clave='" + this.txtClave.Text + "',mail='" + this.txtEmail.Text + "' WHERE nombre='" + this.txtNombreUsuario.Text + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1) { lblConfirmacion.Text = "Se han modificado los datos del usuario"; }
            else { lblConfirmacion.Text = "No existe el usuario"; }            
            conexion.Close();
        }
    }
}