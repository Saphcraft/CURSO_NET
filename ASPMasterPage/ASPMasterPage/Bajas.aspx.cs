using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPMasterPage
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("DELETE FROM cliente WHERE ID='" + int.Parse(this.ddID.Text) + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1) { lblConfirmacion.Text = "Se borró el usuario"; }
            else { lblConfirmacion.Text = "No existe un usuario con dicho nombre"; }
            conexion.Close();
            GridDatos.DataBind();
            ddID.SelectedIndex = 0;
        }

    }
}