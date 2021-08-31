using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoJueveClases
{
    class Vehiculo
    {
        //Atributos
        private int _intID;
        private string _strMarca;
        private string _strModelo;
        private int _intKM;
        private double _dblPrecio;
        //Propiedades
        public int PID
        {
            get { return _intID; }
            set { _intID = value; }
        }
        public string PMarca
        {
            get { return _strMarca; }
            set { _strMarca = value; }
        }
        public string PModelo
        {
            get { return _strModelo; }
            set { _strModelo = value; }
        }
        public int PKM
        {
            get { return _intKM; }
            set { _intKM = value; }
        }
        public double PPrecio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }
        //Constructores
        //constructor default
        public Vehiculo() { }
        //Constructor con parámetros
        public Vehiculo(int cID, string cMarca, string cModelo, int cKM, double cPrecio)
        {
            this._intID = cID;
            this._strMarca = cMarca;
            this._strModelo = cModelo;
            this._intKM = cKM;
            this._dblPrecio = cPrecio;
        }      
    }
}
