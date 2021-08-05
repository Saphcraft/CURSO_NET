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
//using System.Windows.Shapes;

namespace Ejercicio_Filtros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //inicializamos la clase de contexto ( conexion con sql, transferencias de datos, etc)
        //siempre en la clase MainWindows si es WPF, porque es una variable global
        datosJuevesContextoDataContext filtros = new datosJuevesContextoDataContext();
        public MainWindow()
        {
            /// <summary>
            /// Inicializar Formulario y cargamos Grid con TODOS LOS DATOS
            /// </summary>
            InitializeComponent();
            cargarGrid();

        }

        void cargarGrid()
        {
            var listagrid = from f in filtros.datosJueves select f;
            DGV1.ItemsSource = listagrid;
        }
        //metodo para mostrar los registros de un curso determinado
        void cargarGridCurso()
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosJueves where
            f.Curso == curso select f;
            DGV1.ItemsSource = listagrid;
        }
        //metodo con linq para filtrar por el nombre
        //el contains es lo mismo que el like en sql
        void cargarGridNombre(String cadena)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosJueves where f.Curso == curso && f.Nombre.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;
        }
        //metodo con linq para filtrar por el apellido
        void cargarGridApellido(String cadena)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosJueves where f.Curso == curso && f.Apellidos.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;
        }
        //metodo con linq para filtrar por el apellido y nombre
        void cargarGridApellidoNombre(String cadena, string cadena2)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosJueves where f.Curso == curso && f.Apellidos.Contains(cadena) && f.Nombre.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;
        }
        //metodo con linq para filtrar por fecha
        void cargarGridFecha(DateTime desde, DateTime hasta)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosJueves where f.Curso == curso && f.Fecha_inscripcion.Value >= desde && f.Fecha_inscripcion.Value <= hasta select f;
            DGV1.ItemsSource = listagrid;
        }
        /// <summary>
        /// Habilitar y deshabilit Checkbox de las fechas
        /// </summary>
        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = true;
        }

        private void CheckBox1_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = false;
        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = true;
        }

        private void CheckBox2_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = false;
        }

        private void CheckBox4_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = true;
        }

        private void CheckBox4_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = false;
        }

        private void CheckBox5_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = true;
        }

        private void CheckBox5_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = false;

        }

        /// <summary>
        ///Deshabilita instructores
        /// </summary>

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsChecked = true;
            CheckBox5.IsChecked = true;
        }

        private void CheckBox3_UnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsChecked = false;
            CheckBox5.IsChecked = false;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                cargarGridApellidoNombre(TextBox1.Text, TextBox2.Text);
            }
            else if (TextBox1.Text != "" && TextBox2.Text == "")
            {
                cargarGridNombre(TextBox1.Text);
            }
            else if (TextBox1.Text == "" && TextBox2.Text != "")
            {
                cargarGridApellido(TextBox2.Text);
            }
            else
            {
                cargarGridCurso();
            }
        }

        private void fechas_Click(object sender, RoutedEventArgs e)
        {
            if(CheckBox1.IsChecked == true && CheckBox2.IsChecked == true)
            {
                cargarGridFecha(DatePicker1.DisplayDate, DatePicker2.DisplayDate);
            }
        }
    }
}
