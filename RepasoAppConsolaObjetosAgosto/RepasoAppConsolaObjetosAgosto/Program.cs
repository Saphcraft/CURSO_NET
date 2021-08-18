using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoAppConsolaObjetosAgosto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                //Pedir nombre, apellidos y dni que son comunes a empleado y cliente
                Console.WriteLine("Por favor, introduce nombre");
                string name = Console.ReadLine();
                Console.WriteLine("Por favor, introduce Apellidos");
                string surname = Console.ReadLine();
                Console.WriteLine("Por favor, introduce DNI");
                string DNI = Console.ReadLine();
                //Preguntar si es empleado o cliente
                Console.WriteLine("\n1. Para empleado\n 2. Para cliente\n 3. Cancelar");
                string respuesta = Console.ReadLine();
                switch (respuesta)
                {
                    //EMPLEADO
                    case "1":   
                        Empleado MyEmpleado = new Empleado();
                        MyEmpleado.PNombre = name;
                        MyEmpleado.PApellidos = surname;
                        MyEmpleado.PDocumento = DNI;
                        MyEmpleado.calcularSueldo();
                        MyEmpleado.mostrar();
                        break;
                    //CLIENTE
                    case "2":
                        Cliente MyCliente = new Cliente();
                        MyCliente.PNombre = name;
                        MyCliente.PApellidos = surname;
                        MyCliente.PDocumento = DNI;
                        MyCliente.generarCodigo();
                        MyCliente.mostrar();
                        break;  
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ha ocurrido algun error, reinicie el proceso");
            } 
        }
    }
}
