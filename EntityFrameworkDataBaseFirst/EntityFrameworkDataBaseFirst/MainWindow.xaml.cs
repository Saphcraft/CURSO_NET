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

namespace EntityFrameworkDataBaseFirst
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseDatosEntityEntities BaseDatosEntity = new BaseDatosEntityEntities();
        public static DataGrid ControlDatagrid;
        public MainWindow()
        {
            InitializeComponent();
            //Cargamos el DataGrid con los datos
            InitializeComponent();
            MyDG.ItemsSource = BaseDatosEntity.Profesores.ToList();
            ControlDatagrid = MyDG;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //El primer botón llama al cuadro de insertar
            VentanaInsertar vinsertar = new VentanaInsertar();
            vinsertar.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //el Segundo botón llama al cuadro Modificar
            int id = (MyDG.SelectedItem as Profesores).Id;
            VentanaModificar VCambiar = new VentanaModificar(id);
            VCambiar.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id = (MyDG.SelectedItem as Profesores).Id;
            var deleteProfe = BaseDatosEntity.Profesores.Where(m => m.Id == id).Single();
            BaseDatosEntity.Profesores.Remove(deleteProfe);
            BaseDatosEntity.SaveChanges();
            ControlDatagrid.ItemsSource = BaseDatosEntity.Profesores.ToList();
        }
    }
}
