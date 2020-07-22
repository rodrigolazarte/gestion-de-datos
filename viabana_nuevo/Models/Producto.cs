using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class Producto
    {
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Id { get; set; }
        public string Proveedor { get; set; }

        public string UrlImagen { get; set; }

    }
}