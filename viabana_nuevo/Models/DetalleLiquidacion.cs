using System;
using System.Collections.Generic;

namespace viabana_nuevo.Models
{
    public class DetalleLiquidacion
    {
        public int Id { get; set; }
        public Empleado Empleado { get; set; }
        public List<DetalleConcepto> DetallesConceptos { get; set; }
        public DateTime FechaLiquidacion { get; set; }
        public Banco Banco { get; set; }
        public float TotalLiquidado { get; set; }
    }
}