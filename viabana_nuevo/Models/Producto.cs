using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class Producto
    {
        public Categoria Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Id { get; set; }
        public string Proveedor { get; set; }
        public string UrlImagen { get; set; }

        public static List<Producto> filtrarPorCategoria(int idCategoria)
        {
            var listaProductos = GeneradorDatos.GenerarProductos();
            var salida = listaProductos.Where(x => x.Categoria.Id == idCategoria).ToList();
            return salida;
        }

    }
}