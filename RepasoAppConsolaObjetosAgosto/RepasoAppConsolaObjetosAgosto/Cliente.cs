using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoAppConsolaObjetosAgosto
{
    public class Cliente : Persona
    {
        //atributos de empleado
        private string strCategoria;
        private string strCodigo;
        //constructor vacio
        public Cliente() { }
        //constructor de empleado debe llevar los 5 parametros con el tipo de dato y luego hace referencia a donde coge su contenido en : base
        public Cliente(string xnombre, string xapellidos, string xdocumento, string xcategoria, string xcodigo) : base(xnombre, xapellidos, xdocumento)
        {
            strCategoria = xcategoria;
            strCodigo = xcodigo;
        }
        //Metodo
        public void generarCodigo()
        {
            string letrasNombre = strNombre.Substring(0, 2);
            string numerosDNI = strDocumento.Substring(0, 1);
            string codigo = "C" + letrasNombre + numerosDNI;
        }
       
    }
}
