using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaAppPRODUCTOS
{
    class Pedido : Producto
    {
        //atributos y propiedades heredados de Producto
        public int cantidad;
        public double total, IVA, totalConIVA;
        public int PCantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public double PTotal
        {
            get { return total; }
            set { total = value; }
        }
        public double PIVA
        {
            get { return IVA; }
            set { IVA = value; }
        }
        public double PtotalConIVA
        {
            get { return totalConIVA; }
            set { totalConIVA = value; }
        }
        //metodos
        public void operar()
        {
            this.total += PCantidad * PPrecio;
            this.IVA = total * (PIVA / 100);
            this.totalConIVA = total + IVA;
            //al ser protected puede accederse desde los atributos: resultado = valor1 + valor2;
        }
    }
}
