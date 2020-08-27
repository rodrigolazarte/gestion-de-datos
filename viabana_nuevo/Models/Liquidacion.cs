using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class Liquidacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public List<DetalleLiquidacion> DetalleLiquidaciones { get; set; }
        public DateTime Periodo { get; set; }
        public bool Estado { get; set; }
    }
}