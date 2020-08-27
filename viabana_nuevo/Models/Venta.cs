using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace viabana_nuevo.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public float MontoVenta { get; set; }
        public List<LineaDeVenta> LineasDeVentas { get; set; }
        public Cliente Cliente { get; set; }
        public bool Estado { get; set; }

    }
}