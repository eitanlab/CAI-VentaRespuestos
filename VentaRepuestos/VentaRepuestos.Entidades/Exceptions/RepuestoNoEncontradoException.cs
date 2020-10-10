using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Entidades.Exceptions
{
    public class RepuestoNoEncontradoException : Exception
    {
        public RepuestoNoEncontradoException() : base("repuesto no encontrado") {}
    }
}
