using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Entidades.Exceptions
{
    public class RepuestoConStockException : Exception
    {
        public RepuestoConStockException() : base("El repuesto no puede eliminarse porque tiene stock")
        {
        }
    }
}
