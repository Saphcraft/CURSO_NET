using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHUCALINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext HOSPITALLINQ = new DataClasses1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        //Metodo para cargar el grid de datos
        void cargarGrid()
        {
            var cargarGrid = from paciente in HOSPITALLINQ.Enfermo select paciente;
            GridDatos.DataSource = cargarGrid;
        }
        //Boton crear registro
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            try
            {
                Enfermo nuevoPaciente = new Enfermo();
                nuevoPaciente.inscripcion = int.Parse(txtInscripcion.Text);
                nuevoPaciente.Apellido = txtNombreApellidos.Text;
                nuevoPaciente.S = seleccion;
                if (rdFemale.Checked == true)
                {
                    seleccion = "F";
                }
                else
                {
                    if (rdMale.Checked == true)
                    {
                        seleccion = "M";
                    }
                    else
                    {
                        txtMensajes.Text = "Recuerde seleccionar género";
                    }
                }
                nuevoPaciente.Fecha_Nac = dtpFecha.Value;
                nuevoPaciente.Direccion = txtDireccion.Text;
                nuevoPaciente.NSS = int.Parse(txtNumSS.Text);
                HOSPITALLINQ.Enfermo.InsertOnSubmit(nuevoPaciente);
                HOSPITALLINQ.SubmitChanges();
                cargarGrid();
                txtMensajes.Text = "Se ha registrado correctamente";
            }
            catch
            {
                txtMensajes.Text = "No se ha podido dar de alta, revise los datos introducidos";
            }

        }
        //limpiar datos introducidos
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInscripcion.Text = "";
            txtNombreApellidos.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
            dtpFecha.Value = DateTime.Now;
            txtDireccion.Text = "";
            txtNumSS.Text = "";
            txtMensajes.Text = "Limpieza completada";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var seleccion = "";
            try
            {
                Enfermo modificaPaciente = HOSPITALLINQ.Enfermo.Single(enferm => enferm.inscripcion == int.Parse(txtInscripcion.Text));
                modificaPaciente.inscripcion = int.Parse(txtInscripcion.Text);
                modificaPaciente.Apellido = txtNombreApellidos.Text;
                modificaPaciente.S = seleccion;
                if (rdFemale.Checked == true)
                {
                    seleccion = "F";
                }
                else
                {
                    if (rdMale.Checked == true)
                    {
                        seleccion = "M";
                    }
                    else
                    {
                        txtMensajes.Text = "Recuerde seleccionar género";
                    }
                }
                modificaPaciente.Fecha_Nac = dtpFecha.Value;
                modificaPaciente.Direccion = txtDireccion.Text;
                modificaPaciente.NSS = int.Parse(txtNumSS.Text);
                HOSPITALLINQ.SubmitChanges();
                cargarGrid();
                txtMensajes.Text = "El paciente se ha modificado correctamente";

            }
            catch
            {
                txtMensajes.Text = "No se ha podido competar la modificación del registro, revise los datos introducidos";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Enfermo borrarPaciente = HOSPITALLINQ.Enfermo.Single(enferm => enferm.inscripcion == int.Parse(txtInscripcion.Text));
                HOSPITALLINQ.Enfermo.DeleteOnSubmit(borrarPaciente);
                HOSPITALLINQ.SubmitChanges();
                cargarGrid();
                txtMensajes.Text = "Se ha eliminado el paciente correctamente";
            }
            catch
            {
                txtMensajes.Text = "No se ha podido eliminar el paciente, revise el numero de inscripción";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
