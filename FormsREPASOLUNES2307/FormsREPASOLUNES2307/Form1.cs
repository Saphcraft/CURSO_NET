using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsREPASOLUNES2307
{
    public partial class Form1 : Form
    {
        //Creamos el objeto de la clase de acceso a SQL SERVER
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        //creamos el metodo para listar en el el grid de datos
        void ToList()
        {
            GridDatos.DataSource = ClienteLinq.spToList();
        }
        public Form1()
        {
            InitializeComponent();
            this.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ToList();
        }
        //Programar acciones del boton NUEVO
        private void btnNEW_Click(object sender, EventArgs e)
        {
            txtAPELLIDOS.Text = "";
            txtNOMBRE.Text = "";
            txtIDCLIENTE.Text = "";
            txtSearch.Text = "";
        }
        //Programar acciones del boton AGREGAR
        private void btnADD_Click(object sender, EventArgs e)
        {
            ClienteLinq.spAddCustomer(txtIDCLIENTE.Text, txtAPELLIDOS.Text, txtNOMBRE.Text);
            this.ToList();
        }
        //Programar acciones del boton MODIFICAR
        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            ClienteLinq.spUpdateCustomer(txtIDCLIENTE.Text, txtAPELLIDOS.Text, txtNOMBRE.Text);
            this.ToList();
        }
        //Programacion accioens del boton ELIMINAR
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            ClienteLinq.spDeleteCustomer(txtIDCLIENTE.Text);
            this.ToList();
        }
    }
}
