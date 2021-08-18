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

        //Propiedades
        public string PCategoria
        {
            get { return strCategoria; }
            set { strCategoria = value; }
        }
        public string PCodigo
        {
            get { return strCodigo; }
            set { strCodigo = value; }
        }
        //Metodo
        public void generarCodigo()
        {
            Console.WriteLine("Por favor, Introduce la categoria del cliente");
            this.PCategoria = Console.ReadLine();
            string letrasNombre = this.strNombre.Substring(0, 3);
            string numerosDNI = this.strDocumento.Substring(0, 2);
            this.strCodigo = "C" + letrasNombre + numerosDNI;
        }
        public void mostrar()
        {
            Console.WriteLine(strNombre + ", " + strApellidos + ", " + strDocumento + ", " + strCategoria + ", " + strCodigo);
        }
    }
}
