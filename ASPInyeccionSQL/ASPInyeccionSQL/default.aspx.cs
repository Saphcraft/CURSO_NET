using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPInyeccionSQL
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (IsValid) Response.Redirect("alta.aspx");
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            if (IsValid) Response.Redirect("consulta.aspx");
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            if (IsValid) Response.Redirect("baja.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (IsValid) Response.Redirect("modificacion.aspx");
        }
    }
}