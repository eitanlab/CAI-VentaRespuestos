using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Entidades
{
    public static class CategoriasHelper
    {
        public static void generarCategorias() {
            Categoria A = new Categoria(0, "Motor");
            Categoria B = new Categoria(1, "Chasis");
            Categoria C = new Categoria(2, "Accesorios");
        }

    }
}
