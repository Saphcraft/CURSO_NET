using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPMasterPage
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void btnAlta_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into cliente(ID,nombre,apellido1,apellido2,ciudad,categoria) VALUES('" + int.Parse(this.txtId.Text) + "','" + this.txtNombre.Text + "','" + this.txtApellido1.Text + "','" + this.txtApellido2.Text + "','" + this.txtCiudad.Text + "','" + int.Parse(this.txtCategoria.Text) + "')", conexion);
            comando.ExecuteNonQuery();
            lblConfirmacion.Text = "Se registro el usuario";
            conexion.Close();
        }
    }
}