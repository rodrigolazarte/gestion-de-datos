using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public float TotalCompra { get; set; }
        public string Proveedor { get; set; }
        public string Fecha { get; set; }

    }
}