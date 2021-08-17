﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoAppConsolaObjetosAgosto
{
    public class Persona
    {
        //atributos privados pero heredables y modificables a traves de sus propiedades
        protected string strNombre;
        protected string strApellidos;
        protected string strDocumento;
        //constructor vacio
        public Persona() { }
        //constructor de personas con parametros y sobrecarga la clase persona
        public Persona(string xnombre, string xapellidos, string xdocumento)
        {
            strNombre = xnombre;
            strApellidos = xapellidos;
            strDocumento = xdocumento;
        }
    }
}
