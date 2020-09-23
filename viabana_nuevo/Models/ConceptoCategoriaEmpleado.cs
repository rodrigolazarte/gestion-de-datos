using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class ConceptoCategoriaEmpleado
    {
        public int ConceptoId { get; set; }
        public int CategoriaEmpleadoId { get; set; }
        public Concepto Concepto { get; set; }
        public CategoriaEmpleado CategoriaEmpleado { get; set; }
    }
}