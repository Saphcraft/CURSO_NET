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
           
            Cliente MyCliente = new Cliente();
            //Preguntar si es empleado o cliente
            Console.WriteLine("¿Desea ingresar EMPLEADO o CLIENTE? [E/C]");
            string respuesta = Console.ReadLine();
            if ( respuesta == "E" || respuesta =="e")
            {
                Empleado MyEmpleado = new Empleado();
                Console.WriteLine("Escriba nombre: ");

                //TO DO: HACER LAS PROPIEDADES DE ACCESO EN PERSONA, CLIENTE Y EMPLEADO PARA PODER ACCEDER A ELLAS
                MyEmpleado.
                  
            }
            else
            {
                Console.WriteLine("Escriba 'E' para empleado, ó, 'C' para cliente");
            }





            
        }
    }
}
