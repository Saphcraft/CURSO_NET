using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HereciasClasesFiestas
{
    class Fiesta
    {
        //Atributos protected al ser clase padre para que las clases hijas puedan heredar directamente los atributos en lugar de heredar a través de las propiedades
        //Dato introducido
        protected int intNumPersonas;
        protected double dblCosteComidaPorPersona;
        protected double dblBonoExtra;
        protected bool boDecoracion;

        //dato calculado
        protected double dblCostoDecoracion;

        //Propiedades publicas para acceder desde las subclases
        public int pNumPersonas
        {
            get { return intNumPersonas; }
            set { intNumPersonas = value; }
        }
        public double pCostoDecoracion
        {
            get { return dblCostoDecoracion; }
            set { dblCostoDecoracion = value; }
        }
        public double pBonoExtra
        {
            get { return dblBonoExtra; }
            set { dblBonoExtra = value; }
        }
        public double pCosteComidaPorPersona
        {
            get { return dblCosteComidaPorPersona; }
            set { dblCosteComidaPorPersona = value; }
        }
        public bool pDecoracion
        {
            get { return boDecoracion; }
            set { boDecoracion = value; }
        }
        //Constructor default
        public Fiesta() { }
        //Constructor con 5 parámetros
        public Fiesta(int d1, double d2, double d3, double d4, bool d5)
        {
            intNumPersonas = d1;
            dblCostoDecoracion = d2;
            if (pNumPersonas > 12)
            {
                Console.WriteLine("Introduzca el importe del Bono");
                dblBonoExtra = double.Parse(Console.ReadLine());
                dblBonoExtra = d3;
            }
            else
            {
                d3 = 0;
            }
            dblCosteComidaPorPersona = d4;
            boDecoracion = d5;
        }
        //metodo para el costo de decoracion()
        public double CalcularCostoDeDecoracion(bool pDecoracion)
        {
            if (pDecoracion == true)
            {
                if (intNumPersonas > 20)
                {
                    dblCostoDecoracion = intNumPersonas * 200;
                }
                else
                {
                    dblCostoDecoracion = intNumPersonas * 160;
                }
            }
            else
            {
                dblCostoDecoracion = 0;
            }
            return dblCostoDecoracion;
        }
        public void imprimir()
        {
            Console.WriteLine("El número de personas es: " + pNumPersonas + "\nEl coste de decoración es: " + pCostoDecoracion + "\nEl valor del bono es: " + pBonoExtra + "\nEl total de la comida por persona es: " + pCosteComidaPorPersona);
        }

    }
}
