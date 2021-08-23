using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HereciasClasesFiestas
{
    class FiestaDeCumpleaños : Fiesta
    {
        //Atributos
        private int intSizePastel;
        private string strTextoPastel;
        //Propiedades
        public int pSizePastel
        {
            get { return intSizePastel; }
            set { intSizePastel = value; }
        }
        public string pTextoPastel
        {
            get { return strTextoPastel; }
            set { strTextoPastel = value; }
        }
        //Constructor default
        public FiestaDeCumpleaños() { }
        //Constructor con 5 parámetros
        public FiestaDeCumpleaños(int dc1, string dc2, int d1, double d2, double d3, double d4, bool d5) : base(d1, d2, d3, d4, d5)
        {
            intSizePastel = dc1;
            strTextoPastel = dc2;
        }
        //Metodos      
        //metodo para calcular costo total()
        public void CalcularCosto()
        {   //coste total base
            double costeTotal = 0;
            costeTotal = pCosteComidaPorPersona * pNumPersonas;
            //coste de decoracion
            CalcularCostoDeDecoracion(pDecoracion);
            costeTotal += pCostoDecoracion;
            //coste del pastel en funcion de su tamaño
            if (pNumPersonas <= 4)
            {
                pSizePastel = 50;
                costeTotal += pSizePastel;
            }
            else
            {
                pSizePastel = 100;
                costeTotal += pSizePastel;
            }
            //salida por pantalla de los datos
            imprimir();
            Console.WriteLine("\nEl coste del pastel es: " + pSizePastel + "\nEl texto personalizado del pastel es: " + pTextoPastel +
                "\nEl precio total de la fiesta de cumpleaños es: " + costeTotal);
        }
    }
}
