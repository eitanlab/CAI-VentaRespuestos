using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        public VentaRepuestos(string nombre, string direccion)
        {
            _nombreComercio = nombre;
            _direccion = direccion;
            _listaRepuestos = new List<Repuesto>();
        }
        public string NombreComercio
        {
            get { return _nombreComercio; }
            set { _nombreComercio = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public Repuesto BuscarRepuesto(int codigo)
        {
            Repuesto rep = _listaRepuestos.Find(item => item.Codigo == codigo);
            if (rep == null)
                throw new RepuestoNoEncontradoException();
            return rep;
        }
        public void AgregarRepuesto(Repuesto repuesto)
        {
            _listaRepuestos.Add(repuesto);
        }
        public void QuitarRepuesto(int codigo)
        {
            Repuesto rep = BuscarRepuesto(codigo);
                    if (rep.Stock > 0)
                        throw new RepuestoConStockException();
                    _listaRepuestos.Remove(rep);
        }
        public void ModificarPrecio(int codigo, double nuevoPrecio)
        {
            Repuesto rep = BuscarRepuesto(codigo);
            rep.Precio = nuevoPrecio;
        }
        public void AgregarStock(int codigo, int unidades)
        {
            Repuesto rep = BuscarRepuesto(codigo);
            rep.Stock += unidades;
        }
        public void QuitarStock(int codigo, int unidades)
        {
            Repuesto rep = BuscarRepuesto(codigo);
            if (rep.Stock - unidades < 0)
                throw new StockNegativoException();
            rep.Stock -= unidades;
        }
        public string ListarPorCategoria(int codigoCategoria)
        {
            string listaRepuestosPorCategoria = ""; 
            _listaRepuestos.ForEach(repuestoItem =>
            {
                if(repuestoItem.CategoriaDeRepuesto.Codigo == codigoCategoria)  
                    listaRepuestosPorCategoria += repuestoItem.ToString() + "\n";
            });
            return listaRepuestosPorCategoria;
        }
    }
}
