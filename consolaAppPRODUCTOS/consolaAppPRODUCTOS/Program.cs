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
            Pedido nuevoPedido = new Pedido();

            //Crear variables para recibir cadenas
            string c1 = "", c2 = "", eleccion = "";
            double n1 = 0;
            //crear menu con crear objeto, cambiar datos, listar datos y salir
            do
            {
                Console.WriteLine("Pulse:\n1. CREAR OBJETO\n2. HACER PEDIDO\n3. MOSTRAR EL TOTAL + IVA\n4. NUEVO PEDIDO\n5. SALIR");
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
                        Console.WriteLine("Se ha creado correctamente \n");

                        break;
                    //el usuario hace el pedido
                    case "2":                       
                        Console.WriteLine("Escribe la cantidad que desea de: " + c1);
                        nuevoPedido.PCantidad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el IVA que desa aplicar");
                        nuevoPedido.PIVA = double.Parse(Console.ReadLine());
                        nuevoPedido.PPrecio = n1;
                        nuevoPedido.operar();
                        Console.WriteLine("EL total del pedido se a actualizado: " + nuevoPedido.PTotal + "\n");
                        break;                      
                    //Mostrar total + IVA
                    case "3":
                        Console.WriteLine("El total del pedido sin IVA: " + nuevoPedido.PTotal + "\n con un IVA total de: " + nuevoPedido.IVA);
                        Console.WriteLine("TOTAL A PAGAR: " + nuevoPedido.PtotalConIVA);
                        break;
                    case "4":
                        nuevoPedido.total = 0;
                        nuevoPedido.IVA = 0;
                        break;
                    //salir de la aplicacion
                    case "5":
                        Console.WriteLine("ADIOS");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("has introducido un valor incorrecto");
                        break;
                }
            } while (eleccion != "5");
        }

    }
}
