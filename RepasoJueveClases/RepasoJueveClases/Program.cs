using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoJueveClases
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables de construccion y eleccion
            int d1 = 0, d4 = 0, opcion = 0;
            string d2 = "", d3 = "", extra = "";
            double d5 = 0;
            bool d6 = true;
            Coche MyCoche = new Coche();
            Moto MyMoto = new Moto();
            //TO DO: CONVERTIR LA SOLICITUD DE DATOS EN UN METODO PARA LOS PRIMEROS 5 PARAMETROS
            try
            {
                do
                {
                    //Menu
                    Console.WriteLine("Elija qué desea hacer: \n1.- Crear Coche. \n2.- Crear Moto. \n3.- Listar datos del Coche. \n4.- Listar datos de la moto \n5.- Salir.");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        default:
                            Console.WriteLine("Por favor elija una opción válida");
                            break;
                        case 1:
                            Console.WriteLine("\nIntroduce Matrícula: ");
                            d1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nIntroduce Marca: ");
                            d2 = Console.ReadLine();
                            Console.WriteLine("\nIntroduce Modelo: ");
                            d3 = Console.ReadLine();
                            Console.WriteLine("\nIntroduce KM: ");
                            d4 = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nIntroduce Precio: ");
                            d5 = double.Parse(Console.ReadLine());
                            Console.WriteLine("\n¿Tiene Airbag? [S o N]");
                            extra = Console.ReadLine();
                            if (extra == "S" || extra == "s")
                            {
                                d6 = true;
                            }
                            MyCoche = new Coche(d1, d2, d3, d4, d5, d6);
                            break;
                        case 2:
                            Console.WriteLine("\nIntroduce Matrícula: ");
                            d1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nIntroduce Marca: ");
                            d2 = Console.ReadLine();
                            Console.WriteLine("\nIntroduce Modelo: ");
                            d3 = Console.ReadLine();
                            Console.WriteLine("\nIntroduce KM: ");
                            d4 = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nIntroduce Precio: ");
                            d5 = double.Parse(Console.ReadLine());
                            Console.WriteLine("\n¿Tiene Airbag? [S o N]");
                            extra = Console.ReadLine();
                            if (extra == "S" || extra == "s")
                            {
                                d6 = true;
                            }
                            MyMoto = new Moto(d1, d2, d3, d4, d5, d6);
                            break;
                        case 3:
                            MyCoche.listar();
                            break;
                        case 4:
                            MyMoto.listar();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                    }
                } while (opcion != 5);
            }
            catch
            {   //controlar que se mete una opcion válida y dentro del rango
                string control = opcion.ToString();
               if(control == "") { Console.WriteLine("Debe introducir una opción válida\n"); }
               else if(opcion < 0 && opcion > 5 ) { Console.WriteLine("No existe la opción elegida\n"); }
               else { Console.WriteLine("Ocurrió un error inesperado, reinicie la aplicación\n");
                    Console.ReadLine();
                }
            }   
        }
    }
}
