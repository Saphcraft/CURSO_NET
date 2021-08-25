using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerEntornoASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "1";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Label1.Text); x++; Label1.Text = x.ToString();
        }

        protected void btnResultado_Click(object sender, EventArgs e)
        {
            int x1; int x2; int RESULTADO;
            RESULTADO = 0;
            x1 = 0;
            x2 = 0;
            x1 = int.Parse(TextBox1.Text);
            x2 = int.Parse(TextBox2.Text);
            if (sumar.Checked)
            {
                RESULTADO = x1 + x2;
                Label1.Text = "La suma de los dos valores es:" + RESULTADO;
            }
            else
            {
                RESULTADO = x1 - x2;
                Label1.Text = "La suma de los dos valores es:" + RESULTADO;
            }
        }

        protected void btnDrop_Click(object sender, EventArgs e)
        {
            int x1; int x2; int RESULTADO;
            RESULTADO = 0;
            x1 = 0;
            x2 = 0;
            x1 = int.Parse(TextBox3.Text);
            x2 = int.Parse(TextBox4.Text);
            if (operaciones.Items[0].Selected) { int suma = x1 + x2; Label6.Text = "La suma es:" + suma + "<br>"; }
            if (operaciones.Items[1].Selected) { int suma = x1 - x2; Label6.Text = "La suma es:" + suma + "<br>"; }
            if (operaciones.Items[2].Selected) { int suma = x1 / x2; Label6.Text = "La suma es:" + suma + "<br>"; }
            if (operaciones.Items[3].Selected) { int suma = x1 * x2; Label6.Text = "La suma es:" + suma + "<br>"; }
        }
    }
}