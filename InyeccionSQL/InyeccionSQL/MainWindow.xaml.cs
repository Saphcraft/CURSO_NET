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
using System.Data.SqlClient;

namespace InyeccionSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection conexion = new SqlConnection("server  = ASATA404\\SQLEXPRESSSAPH; Initial Catalog=INYECCIONSQL ; Persist Security info=True; User ID=sa;Password=1234");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = txtIDinsertar.Text;
            string nombre = txtNombreInsertar.Text;
            string edad = txtEdadInsertar.Text;
            string cadena = "insert into Personas (id,nombre,edad) " + "values(" + iden + ",'" + nombre + "'," + edad + ")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            conexion.Close();
        }
    }
}
