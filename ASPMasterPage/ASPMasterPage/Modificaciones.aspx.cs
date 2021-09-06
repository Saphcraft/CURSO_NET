using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPMasterPage
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT ID,nombre,apellido1,apellido2,ciudad,categoria FROM cliente WHERE ID=" + int.Parse(this.ddID.Text), conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lblConfirmacion.Text = "ID: " + registro["ID"] + "<br>" + "nombre: " + registro["nombre"] + "<br>" + "apellido1: " + registro["apellido1"] + "<br>" + "apellido2: " + registro["apellido2"] + "<br>" + "ciudad: " + registro["ciudad"] + "<br>" + "categoria: " + registro["categoria"];
                txtNombre.Text = registro["nombre"].ToString();
                txtApellido1.Text = registro["apellido1"].ToString();
                txtApellido2.Text = registro["apellido2"].ToString();
                txtCiudad.Text = registro["ciudad"].ToString();
                txtCategoria.Text = registro["categoria"].ToString();
            }
            else { lblConfirmacion.Text = "No existe un usuario con dicho nombre"; }
            conexion.Close();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE cliente SET " + "nombre='" + this.txtNombre.Text + "',apellido1='" + this.txtApellido1.Text + "',apellido2='" + this.txtApellido2.Text + "',ciudad='" + this.txtCiudad.Text + "',categoria='" + int.Parse(this.txtCategoria.Text) + "' WHERE ID='" + int.Parse(this.ddID.Text) + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1) { lblConfirmacion.Text = "Se han modificado los datos del usuario"; }
            else { lblConfirmacion.Text = "No existe el usuario"; }
            conexion.Close();
        }
    }
}