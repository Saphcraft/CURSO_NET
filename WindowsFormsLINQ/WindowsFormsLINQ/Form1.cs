using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext FormsLINQ = new DataClasses1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        //Metodo para cargar el grid de datos
        void cargarGrid()
        {
            var cargarGrid = from empleados in FormsLINQ.empleados select empleados;
            GridDatos.DataSource = cargarGrid;
            var Buscar = from empleados in FormsLINQ.empleados select empleados;
            GridDatos.DataSource = Buscar;
            int numero = Buscar.Count();
            lbRegistros.Text = "Se han encontrado " + numero + " registros";
        }
        //acciones del boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           var Buscar = from empleados in FormsLINQ.empleados where empleados.Nombre == txtBuscar.Text select empleados;
            GridDatos.DataSource = Buscar;
            int numero = Buscar.Count();
            lbRegistros.Text = "Se han encontrado " + numero + " registros";
        }
        //acciones del boton de alta
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                empleados nuevoEmpleado = new empleados();
                nuevoEmpleado.ID = int.Parse(txtID.Text);
                nuevoEmpleado.Nombre = txtName.Text;
                nuevoEmpleado.Apellido = txtSurname.Text;
                nuevoEmpleado.Edad = int.Parse(txtAge.Text);
                nuevoEmpleado.casado = chkMarried.Checked;
                FormsLINQ.empleados.InsertOnSubmit(nuevoEmpleado);
                FormsLINQ.SubmitChanges();
                cargarGrid();
                chkMarried.Checked = false;
            }
            catch
            {
                MessageBox.Show("No se ha podido dar de alta, revise los datos introducidos");
            }
        }
        //acciones del boton baja
        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                empleados bajaempleado = FormsLINQ.empleados.Single(emp => emp.ID == int.Parse(txtID.Text));
                FormsLINQ.empleados.DeleteOnSubmit(bajaempleado);
                FormsLINQ.SubmitChanges();
                cargarGrid();
                chkMarried.Checked = false;
            }
            catch
            {
                MessageBox.Show("No se ha podido dar de alta, revise los datos introducidos");
            }
        }
        //acciones del boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                empleados modificaempleado = FormsLINQ.empleados.Single(emp => emp.ID == int.Parse(txtID.Text));
                modificaempleado.ID = int.Parse(txtID.Text);
                modificaempleado.Nombre = txtName.Text;
                modificaempleado.Apellido = txtSurname.Text;
                modificaempleado.Edad = int.Parse(txtAge.Text);
                modificaempleado.casado = chkMarried.Checked;
                FormsLINQ.SubmitChanges();
                cargarGrid();
                chkMarried.Checked = false;
            }
            catch
            {
                MessageBox.Show("No se ha podido dar de alta, revise los datos introducidos");
            }
        }
    }
}
