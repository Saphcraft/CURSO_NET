using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient; //libreria de SQL

namespace InyeccionSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {//cadena de conexion con SQL por inyeccion
        private SqlConnection conexion = new SqlConnection("server  = ASATA404\\SQLEXPRESSSAPH; Initial Catalog=INYECCIONSQL ; Persist Security info=True; User ID=sa;Password=1234");
        
        public MainWindow()
        {
            InitializeComponent();
        }
        //boton de insertar
        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            int valor=0;
            string nombre = txtNombreInsertar.Text;
            string edad = txtEdadInsertar.Text;
            string obtener = "SELECT TOP 1 * FROM Personas order by id desc";

            //Método para sacar el último codigo
            //comprobar ID y sumarle uno
            conexion.Open();
            SqlCommand comandID = new SqlCommand(obtener, conexion);
            SqlDataReader regisID = comandID.ExecuteReader();
            if (regisID.Read())
            {
                valor = int.Parse(regisID["ID"].ToString()) + 1;
            }
            else
            {
                MessageBox.Show("Los datos no se obtuvieron...");
            }
            conexion.Close();

            //insertar datos
            conexion.Open();
            string cadena = "INSERT INTO Personas (id,nombre,edad) " + "VALUES(" + valor.ToString() + ",'" + nombre + "'," + edad + ")";
            
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            conexion.Close();            
        }


        private void btnConsultar_Click_1(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string id = txtIDEliminar.Text;
            string cadena = "SELECT id,nombre,edad FROM Personas WHERE id=" + id;
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    lbNombreEliminar.Content = registro["nombre"].ToString();
                    lbEdadEliminar.Content = registro["edad"].ToString();
                    btnBorrar.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("No existe ningun registro con el dato ingresado");
                }
            }
            catch
            {
                MessageBox.Show("El dato insertado no es correcto, recuerde hacer la consulta a través del ID numérico");
            }
            conexion.Close();
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = txtIDEliminar.Text;
            string cadena = "DELETE FROM Personas WHERE id=" + iden;
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se borró el registro correctamente");
                    lbNombreEliminar.Content = "";
                    lbEdadEliminar.Content ="";
                    
                }
                else
                {
                    MessageBox.Show("No existe ningun registro con el dato ingresado");
                }
            }
            catch
            {
                MessageBox.Show("El dato insertado no es correcto, recuerde hacer la consulta a través del ID numérico");
            }
            btnBorrar.IsEnabled = false;
            conexion.Close();
            
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string cod = txtIDModificar.Text;
            string cadena = "SELECT id, nombre, edad FROM Personas WHERE id=" + cod;
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtNombreModificar.Text = registro["nombre"].ToString();
                    txtEdadModificar.Text = registro["edad"].ToString();
                    btnModificar.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("No existe ningun registro con el dato ingresado");
                }
            }
            catch
            {
                MessageBox.Show("El dato insertado no es correcto, recuerde hacer la consulta a través del ID numérico");
            }
            btnModificar.IsEnabled = true;
            conexion.Close();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = txtIDModificar.Text;
            string nombre = txtNombreModificar.Text;
            string edad = txtEdadModificar.Text;
            string cadena = "UPDATE Personas SET nombre='" + nombre + "', edad=" + edad + " WHERE id=" + iden;
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificó el registro correctamente");
                    txtIDModificar.Text = "";
                    txtNombreModificar.Text = "";
                    txtEdadModificar.Text = "";   
                }
                else
                {
                    MessageBox.Show("No existe ningun registro con el dato ingresado");
                }
            }
            catch
            {
                MessageBox.Show("El dato insertado no es correcto, recuerde hacer la consulta a través del ID numérico");
            }
            btnModificar.IsEnabled = false;
            conexion.Close();
        }
    }
}
