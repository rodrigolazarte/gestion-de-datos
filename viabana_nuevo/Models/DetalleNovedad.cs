using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class DetalleNovedad
    {
        public int Id { get; set; }
        public Concepto Novedad { get; set; }
        public int Cantidad { get; set; }
        
        public float Monto;
        public DateTime FechaNovedad { get; set; }
    }
}