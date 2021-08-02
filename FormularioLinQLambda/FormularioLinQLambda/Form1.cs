using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLinQLambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext basededatos = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();
        }
        void cargarCombo()
        {
            var cargarCombo = from p in basededatos.Products select p.ProductName;
            comboBox1.DataSource = cargarCombo;
        }
        void cargarGrid()
        {
            var cargarGrid = from p in basededatos.Products select p;
            GridDatos.DataSource = cargarGrid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Products myProduct = new Products();
            myProduct.ProductName = txtProd.Text;
            myProduct.UnitPrice = int.Parse(txtPrec.Text);
            myProduct.UnitsInStock = short.Parse(txtStock.Text);
            myProduct.CategoryID = int.Parse(txtCat.Text);
            basededatos.Products.InsertOnSubmit(myProduct);
            basededatos.SubmitChanges();
            cargarGrid();
            cargarCombo();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //esto es una sentencia lambda para sacar el nombre que seleccionamos en el combo
            Products myProducto = basededatos.Products.Single(p => p.ProductName == comboBox1.SelectedItem.ToString());
            myProducto.ProductName = comboBox1.SelectedItem.ToString();
            myProducto.UnitPrice = int.Parse(txtPrec.Text);
            myProducto.UnitsInStock = short.Parse(txtStock.Text);
            myProducto.CategoryID = int.Parse(txtCat.Text);
            basededatos.SubmitChanges();
            cargarGrid();
            cargarCombo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //esto es una sentencia lambda para sacar el nombre que seleccionamos en el combo
            Products myProducts = basededatos.Products.Single(p => p.ProductName == comboBox1.SelectedItem.ToString());
            basededatos.Products.DeleteOnSubmit(myProducts);
            basededatos.SubmitChanges();
            cargarGrid();
            cargarCombo();
        }
    }
}
