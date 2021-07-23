using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQtoSQLsp
{
    public partial class Form1 : Form
    {
        //Creamos la clase de acceso a SQL SERVER
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            this.listarClientes();
        }
        void listarClientes()
        {
            GridDatos.DataSource = ClienteLinq.ListarClientes();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtBuscar.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarCliente(txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtTelefono.Text);
            this.listarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.modificarClientes(txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtTelefono.Text);
            this.listarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.eliminarClientes(txtNombre.Text);
            this.listarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GridDatos.DataSource = ClienteLinq.buscarClientes(txtBuscar.Text);
    
        }
    }
     
}
