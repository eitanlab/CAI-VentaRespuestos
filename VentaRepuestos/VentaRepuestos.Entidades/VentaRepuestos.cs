using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestos.Entidades.Exceptions;

namespace VentaRepuestos.Entidades
{
    public class VentaRepuestos
    {
        List<Repuesto> _listaRepuestos;
        string _nombreComercio;
        string _direccion;
        public string NombreComercio
        {
            get { return _nombreComercio; }
        }
        public string Direccion
        {
            get { return _direccion; }
        }
        public void AgregarRepuesto(Repuesto repuesto)
        {
            _listaRepuestos.Add(repuesto);
        }
        public void QuitarRepuesto(int codigo)
        {
            _listaRepuestos.ForEach(repuestoItem =>
            {
                if(repuestoItem.Codigo == codigo)
                {
                    if(repuestoItem.Stock > 0)
                        throw new RepuestoConStockException();
                    _listaRepuestos.Remove(repuestoItem);
                }
            });
        }
        public void ModificarPrecio(int codigo, double nuevoPrecio)
        {
            _listaRepuestos.ForEach(repuestoItem =>
            {
                if (repuestoItem.Codigo == codigo)
                {
                    repuestoItem.Precio = nuevoPrecio;
                }
            });
        }
        public void AgregarStock(int codigo, int sumaStock)
        {
            _listaRepuestos.ForEach(repuestoItem =>
            {
                if (repuestoItem.Codigo == codigo)
                {
                    repuestoItem.Stock += sumaStock;
                }
            });
        }
        public void QuitarStock(int codigo, int restaStock)
        {
            _listaRepuestos.ForEach(repuestoItem =>
            {
                if (repuestoItem.Codigo == codigo)
                {
                    if (repuestoItem.Stock - restaStock < 0)
                        throw new StockNegativoException();
                    repuestoItem.Stock -= restaStock;
                }
            });
        }
        // Falta implementar
        //public List<Repuesto> TraerPorCategoria(int categoria)
        //{

        //}
    }
}
