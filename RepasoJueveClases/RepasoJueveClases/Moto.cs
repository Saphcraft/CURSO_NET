using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoJueveClases
{
    class Moto : Vehiculo
    {
        //Atributos propios
        protected bool blnSidecar;
        //Propiedades de acceso
        public bool PSidecar
        {
            get { return blnSidecar; }
            set { blnSidecar = value; }
        }
        //Constructores
        //constructor default
        public Moto() { }
        //Constructor con parámetros
        public Moto(int cID, string cMarca, string cModelo, int cKM, double cPrecio, bool cSidecar) : base(cID, cMarca, cModelo, cKM, cPrecio)
        {
            this.blnSidecar = cSidecar;
        }
        //Metodos
        //TO DO: METODO PARA MODIFICAR EL PRECIO, SI TIENE SIDECAR EL PRECIO AUMENTARÁ 50 EUROS
        public void precioFinal()
        {
            if (blnSidecar == true)
            {
                PPrecio += 50;
            }
        }
        //metodo para listar
        public void listar()
        {
            Console.WriteLine("SE HA REGISTRADO LA SIGUIENTE MOTO:");
            Console.WriteLine("Código de Identificación: " + PID + "\nMarca: " + PMarca + "\nModelo: " + PModelo + "\nKM: " + PKM + "\nPrecio final: " + PPrecio + "\n");
        }
    }
}
