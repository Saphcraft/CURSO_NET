using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HereciasClasesFiestas
{
    class FiestaDeGala : Fiesta
    {
        //Atributos
        private double dblCostoPromedioPorPersona;
        private bool boOpcionExtra;
        //Propiedades
        public double pCostoPromedioPorPersona
        {
            get { return dblCostoPromedioPorPersona; }
            set { dblCostoPromedioPorPersona = value; }
        }
        public bool pOpcionExtra
        {
            get { return boOpcionExtra; }
            set { boOpcionExtra = value; }
        }
        //Constructor default
        public FiestaDeGala() { }
        //Constructor con 5 parámetros
        public FiestaDeGala(double dg1, bool dg2, int d1, double d2, double d3, double d4, bool d5) : base(d1, d2, d3, d4, d5)
        {
            dblCostoPromedioPorPersona = dg1;
            boOpcionExtra = dg2;
        }
        //Metodos
        /*el método para calcular el costo de la decoracion está declarado en la supercase ya que es un booleano y tiene que hacer el calculo en base a si es verdadero o falso y despues comprobar cuantas personas hay para añadir una cantidad u otra*/
        //metodo para determinar si popcionextra es true o false
        public bool SetExtra()
        {
            string extra = "";
            if (extra == "S" || extra == "s")
            {
                pOpcionExtra = true;
            }
            else
            {
                pOpcionExtra = false;
            }
            return pOpcionExtra;
        }
        //metodo para calcular costo total()
        public void CalcularCosto()
        {   //coste total base
            double costeTotal = 0;
            costeTotal = pCosteComidaPorPersona * pNumPersonas;
           //coste de decoracion
            CalcularCostoDeDecoracion(pDecoracion);
            costeTotal += pCostoDecoracion;
            //coste en caso de elegir extra
            SetExtra();
            if (pOpcionExtra == true)
            {
                costeTotal += pNumPersonas * 40;
            }
            //coste quitando el bono
            if (pNumPersonas > 12)
            {
                Console.WriteLine("Introduce el importe del Bono");
                pBonoExtra = double.Parse(Console.ReadLine());
                costeTotal += pBonoExtra;
            }
            //Calculo del promedio por persona
            pCostoPromedioPorPersona = costeTotal / pNumPersonas;
            //salida por pantalla de los datos
            imprimir();
            Console.WriteLine("\nEl precio total de la fiesta de Gala es: " + costeTotal);
            Console.WriteLine("\nEl precio por Persona es: " + pCostoPromedioPorPersona);
        }
    }
}
