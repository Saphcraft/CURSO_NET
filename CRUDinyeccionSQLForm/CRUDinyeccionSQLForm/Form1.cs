using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //libreria de SQL

namespace CRUDinyeccionSQLForm
{
    public partial class Form1 : Form
    {   //Cadena de conexión con SQL por inyección
        private SqlConnection conexion = new SqlConnection("Data Source=ASATA404\\SQLEXPRESSSAPH;Initial Catalog = INYECCIONSQL; Persist Security Info=True;User ID = sa; Password=1234");
        //Creamos el objeto de la clase para enlazar con los procedimientos de almacenado
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        //Metodo para listar en el Grid de Datos
        void Listar()
        {
            dgvGridDatos.DataSource = ClienteLinq.spListarAlumnos();
        }
        public Form1()
        {
            InitializeComponent();
            this.Listar();
        }
        //refrescar formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
        //Programar boton de busqueda por codigo a través del procedimiento de almacenado 
        private void btnBuscaCodigo_Click(object sender, EventArgs e)
        {
            ClienteLinq.spBuscarAlumnosCODIGO(int.Parse(txtCodigoBusqueda.Text));
            this.Listar();
        }
        //Programar boton de busqueda por DNI a través del procedimiento de almacenado 
        private void btnBuscaDNI_Click(object sender, EventArgs e)
        {
            ClienteLinq.spBuscarAlumnosDNI(txtDNI.Text);
            this.Listar();
        }
        //Operativa del bóton para dar de Alta un Alumno en la base de datos mediante inyeccion SQL
        private void btnAlta_Click(object sender, EventArgs e)
        {
            conexion.Open(); //abre conexión
            //Validacion
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe rellenar el DNI");
            }
            if (cbTurno.Text == "")
            {
                MessageBox.Show("Debe seleccionar el Turno");
            }
            if (cbEspecialidad.Text == "")
            {
                MessageBox.Show("Debe seleccionar la Especialidad");
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe rellenar el Nombre");
            }
            if (cbSexo.Text == "")
            {
                MessageBox.Show("Debe seleccionar el sexo");
            }
            if (cbModulo.Text == "")
            {
                MessageBox.Show("Debe seleccionar el modulo");
            }
            else
            {
                //Declaramos las variables
                //Disabled int codigo = int.Parse(txtCodigo.Text);
                string DNI = txtDNI.Text;
                string turno = cbTurno.Text;
                string especialidad = cbEspecialidad.Text;
                string nombre = txtNombre.Text;
                string sexo = cbSexo.Text;
                string modulo = cbModulo.Text;

                //control del checkbox
                int repetidor = 0;
                if (chkRepetidor.Checked == true) { repetidor = 1; }
                else { repetidor = 0; }

                //Mandar inyeccion para insertar datos

                string cadena = "INSERT INTO ALUMNOS (DNI,TURNO,ESPECIALIDAD,NOMBRE,SEXO,MODULO,REPETIDOR) " + "VALUES('" + DNI + "','" + turno + "','" + especialidad + "','" + nombre + "','" + sexo + "','" + modulo + "','" + repetidor + "')";
                //creamos un objeto de la clase comandosSQL y ejecutar la Query
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                //mostrar mensaje en caso de que se haya guardado correctamente
                MessageBox.Show("Los datos se guardaron correctamente");
                conexion.Close();
                this.Listar();
            }
            //Limpiar controles
            txtDNI.Text = "";
            cbTurno.Text = "";
            cbEspecialidad.Text = "";
            txtNombre.Text = "";
            cbSexo.Text = "";
            cbModulo.Text = "";
        }
        //Operativa del bóton para dar de Alta un Alumno en la base de datos mediante inyeccion SQL
        private void btnBaja_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            //abrir conexión con sql
            conexion.Open();            
            string cadena = "DELETE FROM ALUMNOS WHERE DNI='" + DNI + "'";
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se borró el registro correctamente");
                }
                else
                {
                    MessageBox.Show("No existe ningun registro con el dato ingresado");
                }
            }
            catch
            {
                MessageBox.Show("El dato insertado no es correcto, recuerde hacer la consulta a través del DNI");
            }
            conexion.Close();
            this.Listar();
        }
        //Operativa del bóton paraModificar el registro de un Alumno en la base de datos mediante inyeccion SQL
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            bool registro = true;
            string DNI = txtDNI.Text;
            //try-catch conexión para comprobar que existe el DNI en la base de datos con un control booleano
            conexion.Open();            
            try
            {
                string consulta = "SELECT * FROM ALUMNOS WHERE DNI='" + DNI + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("existe");
                    registro = true;
                    this.Listar();
                }
                else
                {
                    MessageBox.Show("No existe ningun registro con el dato ingresado");
                    registro = false;
                }
            }
            catch
            {
                MessageBox.Show("El dato insertado no es correcto, recuerde hacer la consulta a través del DNI");
            }
            conexion.Close();
            //try-catch si el control booleano es correcto entonces se abre una conexión para lanzar la modificación de los datos
            
            try
            {
                string turno = cbTurno.Text;
                string especialidad = cbEspecialidad.Text;
                string nombre = txtNombre.Text;
                string sexo = cbSexo.Text;
                string modulo = cbModulo.Text;

                if (registro == true)
                {
                    conexion.Open();
                    string cadena = "UPDATE ALUMNOS SET TURNO='" + turno + "', ESPECIALIDAD='" + especialidad + "', NOMBRE='" + nombre + "', SEXO='" + sexo + "', MODULO='" + modulo + " WHERE DNI=" + DNI;
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("no se pudo modificar el registro");
                }
            }
            catch
            {
                MessageBox.Show("El dato insertado no es correcto, recuerde hacer la consulta a través del ID numérico");
            }
            
            this.Listar();
            //Limpiar controles
            txtDNI.Text = "";
            cbTurno.Text = "";
            cbEspecialidad.Text = "";
            txtNombre.Text = "";
            cbSexo.Text = "";
            cbModulo.Text = "";

        }
    }
}
