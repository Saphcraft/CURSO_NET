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
using System.Windows.Shapes;

namespace EntityFrameworkDataBaseFirst
{
    /// <summary>
    /// Lógica de interacción para VentanaModificar.xaml
    /// </summary>
    public partial class VentanaModificar : Window
    {
        BaseDatosEntityEntities BaseDatosEntity = new BaseDatosEntityEntities();
        int id;
        public VentanaModificar(int IdProfesor)
        {
            InitializeComponent();
            id = IdProfesor;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profesores MyProfe = (from m in BaseDatosEntity.Profesores where m.Id == id select m).Single();
            MyProfe.Nombre = TxtNombre.Text;
            MyProfe.Especialidad = cmbEspec.Text;
            BaseDatosEntity.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = BaseDatosEntity.Profesores.ToList();
            this.Hide();
        }
    }
}
