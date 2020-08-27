using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class DetalleConcepto
    {
        public int Id { get; set; }
        public Concepto ConceptoSueldo { get; set; }
        public int Cantidad { get; set; }
        public float Monto { get; set; }
    }
}