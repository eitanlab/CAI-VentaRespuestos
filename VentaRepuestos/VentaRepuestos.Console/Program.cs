using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.VentaRepuestos comercio = new Entidades.VentaRepuestos("Accesorios GDT", "Warnes 1234");
            string menuItems =
                "1. Alta repuesto \n " +
                "2. Baja respuesto \n " +
                "3. Modificar repuesto \n " +
                "4. Listar repuestos por categoria \n " +
                "5. Agregar stock a repuesto \n " +
                "6. Quitar stock a repuesto";
            
            //while()
            //mostrarMenu(menuItems);

        }

        static void menu()
        {

        }
    }
}
