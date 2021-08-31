using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuestionarioASP_NET
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //boton de resultado
        protected void resultado_Click(object sender, EventArgs e)
        {
            int correctas = 0;
            int incorrectas = 0;
            if (p1b.Checked == true)
            {
                correctas++;
            }
            else
            {
                incorrectas++;
            }
            if (p5c.Checked == true)
            {
                correctas++;
            }
            else
            {
                incorrectas++;
            }
            if (p8d.Checked == true)
            {
                correctas++;
            }
            else
            {
                incorrectas++;
            }
            if (p17e.Checked == true)
            {
                correctas++;
            }
            else
            {
                incorrectas++;
            }

            respuestas.Text = "Has acertado: " + correctas.ToString() + "<br>Has fallado: " + incorrectas.ToString();

            if (IsValid) Response.Redirect("AccesoPermitido.aspx");

        }
    }
}