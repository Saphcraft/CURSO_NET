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
    /// Lógica de interacción para VentanaInsertar.xaml
    /// </summary>
    public partial class VentanaInsertar : Window
    {
        BaseDatosEntityEntities BaseDatosEntity = new BaseDatosEntityEntities();

        public VentanaInsertar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int idulti = MyDataGrid.Items.Count+1;
            Profesores MyProfe = new Profesores()
            {
                Id = int.Parse(txtID.Text),
                Nombre = TxtNombre.Text,
                Especialidad = cmbEspec.Text
            };
            BaseDatosEntity.Profesores.Add(MyProfe);
            BaseDatosEntity.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = BaseDatosEntity.Profesores.ToList();
            this.Hide();
        }
    }
}
