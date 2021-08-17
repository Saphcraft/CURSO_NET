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
        //Metodo
        public void calcularSueldo()
        {
            if ( strTipoContrato == "F")
            {
                dblSueldo = dblSueldo + 300;
            }
            else
            {
                dblSueldo = dblSueldo + 250;
            }
        }
    }
}
