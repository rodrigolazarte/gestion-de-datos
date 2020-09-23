using System.Collections.Generic;

namespace viabana_nuevo.Models
{
    public class CategoriaEmpleado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float SueldoBasico { get; set; }
        public List<Concepto> Conceptos { get; set; }
        //public virtual List<ConceptoCategoriaEmpleado> ConceptoCategoriaEmpleados { get; set; }

    }
}