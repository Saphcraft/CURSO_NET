using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaAppPRODUCTOS
{
    class Producto
    {
        //atributos
        private string nombre, categoria;
        private double precio;
        //propiedades
        public string PNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string PCategoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public double PPrecio
        {
            get { return precio; }
            set { precio = value; }
        }
        //constructores
        public Producto() { }
        //constructor de 3 parametros
        public Producto(string c_nombre, double c_precio, string c_categoria)
        {
            this.nombre = c_nombre;
            this.precio = c_precio;
            this.categoria = c_categoria;
        }
        //constructor de 2 parametros
        public Producto(string c_nombre, double c_precio)
        {
            this.nombre = c_nombre;
            this.precio = c_precio;
        }
        //metodos
        public void pedido()
        {

        }
    }
}
