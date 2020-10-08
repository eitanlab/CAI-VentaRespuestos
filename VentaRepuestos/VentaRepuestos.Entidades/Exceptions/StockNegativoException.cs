using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Entidades.Exceptions
{
    public class StockNegativoException : Exception
    {
        public StockNegativoException() : base("El stock del repuesto es menor a la cantidad ingresada") 
        { 
        }
    }
}
