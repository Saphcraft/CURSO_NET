using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaAppPRODUCTOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear el objeto producto
            Producto nuevoProduct = new Producto();

            //Crear variables para recibir cadenas
            string c1 = "", c2 = "", eleccion = "";
            double n1 = 0;
            //crear menu con crear objeto, cambiar datos, listar datos y salir
            do
            {
                Console.WriteLine("Pulse:\n1. CREARORBJETO\n2. HACER PEDIDO\n3. MOSTRAR EL TOTAL + IVA\n4. SALIR");
                eleccion = Console.ReadLine();
                Console.Clear();
                switch (eleccion)
                {
                    //el usuario introduce los datos correspondientes para crear
                    case "1":
                        Console.WriteLine("Escribe el nombre");
                        c1 = Console.ReadLine();
                        Console.WriteLine("Escribe el precio");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe la categoria");
                        c2 = Console.ReadLine();
                        //usa el constructor de 2 parametros
                        nuevoProduct = new Producto(c1, n1);
                        //usa el constructor de 3 parametros
                        nuevoProduct = new Producto(c1, n1, c2);
                        break;
                    //el usuario hace el pedido
                    case "2":


                        Console.Clear();
                       
                    //invocamos el metodo de la clase para listar
                    case "3":
                        mp.Imprimir();
                        break;
                    //salir de la aplicacion
                    case "4":
                        Console.WriteLine("ADIOS");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("has introducido un valor incorrecto");
                        break;
                }
            } while (eleccion != "4");
        }
    }
}
