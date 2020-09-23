using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class LineaDeVenta
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get; set; }

        public void BuscarProducto()
        {
            var listaProductos = GeneradorDatos.GenerarProductos();
            var salida = listaProductos.Find(x => x.Id == this.IdProducto);
            this.Producto = salida;
        }
    }
}