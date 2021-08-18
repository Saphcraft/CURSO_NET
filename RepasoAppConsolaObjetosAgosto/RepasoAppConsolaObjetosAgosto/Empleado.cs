using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoAppConsolaObjetosAgosto
{
    public class Empleado : Persona
    {
        //atributos de empleado
        private string strTipoContrato;
        private double dblSueldo;
        //constructor vacio
        public Empleado() { }
        //constructor de empleado debe llevar los 5 parametros con el tipo de dato y luego hace referencia a donde coge su contenido en : base
        public Empleado(string xnombre, string xapellidos, string xdocumento, string xtipoContrato, double xsueldo) : base( xnombre, xapellidos, xdocumento)
        {
            strTipoContrato = xtipoContrato;
            dblSueldo = xsueldo;
        }
        
        //Propiedades
        public string PTipoContrato
        {
            get { return strTipoContrato; }
            set { strTipoContrato = value; }
        }
        public double PSueldo
        {
            get { return dblSueldo; }
            set { dblSueldo = value; }
        }
        //Metodo
        public void calcularSueldo()
        {
            Console.WriteLine("Por favor, Tipo de contrato [F/T]");
            string tipo = Console.ReadLine();
            strTipoContrato = tipo;
            Console.WriteLine("Por favor, introduce sueldo");
            double sueldo = double.Parse(Console.ReadLine());
            if (tipo == "F" || tipo == "f")
            {
                this.dblSueldo = sueldo + 300;
            }
            else if (tipo == "T" || tipo == "t")
            {
                this.dblSueldo = sueldo + 250;
            }  
            else
            {
                Console.WriteLine("Por favor introduzca 'F' o 'T'");
            }
        }
        public void mostrar()
        {
            Console.WriteLine(strNombre + ", " + strApellidos + ", " + strDocumento + ", " + strTipoContrato + ", " + dblSueldo);
        }
    }
}
