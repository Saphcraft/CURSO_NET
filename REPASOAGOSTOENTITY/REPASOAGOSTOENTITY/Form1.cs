using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPASOAGOSTOENTITY
{
    public partial class Form1 : Form
    {
        REPASO_AGOSTOEntities ClientesEntity = new REPASO_AGOSTOEntities();
        public Form1()
        {
            InitializeComponent();
            cargarGrid();
        }
        public void cargarGrid()
        {
            GridDatos.DataSource = ClientesEntity.CLIENTES.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CLIENTES myCliente = new CLIENTES()
            {
                dni = txtDNI.Text,
                nombre = txtNombres.Text,
                apellidos = txtApellidos.Text,
                estado_civil = cbEstadoCivil.Text,
                email = txtEmail.Text,
                telefono = txtTelefono.Text,
                fecha_nacimiento = dtpFechaNacimiento.Value
            };
            ClientesEntity.CLIENTES.Add(myCliente);
            ClientesEntity.SaveChanges();
            cargarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string textoDNI = txtDNI.Text;
            var deleteCliente = ClientesEntity.CLIENTES.Where(c => c.dni == textoDNI).Single();
            ClientesEntity.CLIENTES.Remove(deleteCliente);
            ClientesEntity.SaveChanges();
            cargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string textoDNI = txtDNI.Text;
            CLIENTES myCliente = (from c in ClientesEntity.CLIENTES where c.dni == textoDNI select c).Single();
            {
                //myCliente.dni = txtDNI.Text;
                myCliente.nombre = txtNombres.Text;
                myCliente.apellidos = txtApellidos.Text;
                myCliente.estado_civil = cbEstadoCivil.Text;
                myCliente.email = txtEmail.Text;
                myCliente.telefono = txtTelefono.Text;
                myCliente.fecha_nacimiento = dtpFechaNacimiento.Value;
            }
            ClientesEntity.SaveChanges();
            cargarGrid();
        }
    }
}
