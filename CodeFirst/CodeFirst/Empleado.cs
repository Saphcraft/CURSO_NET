using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst
{
    public class Empleado
    {
        [Key] //convierte en clave principal a IdEmpleado
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}