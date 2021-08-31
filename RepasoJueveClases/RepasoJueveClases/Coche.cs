using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoJueveClases
{
    class Coche : Vehiculo
    {
        //Atributos propios
        protected bool blnAirbag;
        //Propiedades de acceso
        public bool PAirbag
        {
            get { return blnAirbag; }
            set { blnAirbag = value; }
        }
        //Constructores
        //constructor default
        public Coche() { }
        //Constructor con parámetros
        public Coche(int cID, string cMarca, string cModelo, int cKM, double cPrecio, bool cAirbag) : base (cID, cMarca, cModelo, cKM, cPrecio)
        {
            this.blnAirbag = cAirbag;
        }
        //Metodos
        //TO DO: METODO PARA MODIFICAR EL PRECIO, SI TIENE AIRBAG EL PRECIO AUMENTARÁ 200 EUROS
        public void precioFinal()
        {
            if (blnAirbag == true)
            {
                PPrecio += 200;
            }
        }
        //metodo para listar
        public void listar()
        {
            Console.WriteLine("SE HA REGISTRADO EL SIGUIENTE COCHE:");
            Console.WriteLine("\nMatrícula: " + PID + "\nMarca: " + PMarca + "\nModelo: " + PModelo + "\nKM: " + PKM + "\nPrecio final: " + PPrecio + "\n");
        }
    }
}
