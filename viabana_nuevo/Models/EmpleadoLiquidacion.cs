using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class EmpleadoLiquidacion
    {
        public int IdEmpleado { get; set; }
        public int IdLiquidacion { get; set; }
        public Empleado Empleado { get; set; }
        public Liquidacion Liquidacion { get; set; }
        public float TotalDebe { get; set; }
        public float TotalHaber { get; set; }
        public float TotalBruto { get; set; }
        public float TotalNeto { get; set; }
    }
}