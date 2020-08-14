using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class Liquidacion
    {
        public int Id { get; set; }
        public TipoLiquidacion TipoLiquidacion { get; set; }
        public DateTime FechaInicioLiquidacion { get; set; }
        public DateTime FechaFinLiquidacion { get; set; }
        public bool Estado { get; set; }
        public Banco Banco { get; set; }
        public EmpleadoLiquidacion EmpleadosLiquidaciones { get; set; }
    }
}