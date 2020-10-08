using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Entidades
{
    public class Repuesto
    {
        int _codigo;
        string _nombre;
        double _precio;
        int _stock;
        Categoria _categoria;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        } 
        public override string ToString()
        {
            return "(" + _codigo + ") - " + _nombre + " $" + _precio ;
        }
    }
}
