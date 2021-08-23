using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //para generar entidades desde las tablas
using System.Data.Entity.ModelConfiguration.Conventions; //using para los plurales

namespace CodeFirst.Models
{
    public class ContextoEmpleados : DbContext
    {   //cadena de conexion
        public ContextoEmpleados() : base("Model1Container") { }
        //propiedades tabla empleados
        public DbSet<Empleado> Empleados { get; set; }
        //Evita plurales en tabla
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           
        }
       
    }
}