using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace viabana_nuevo.Models
{
    public class TipoLiquidacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public List<ConceptoSueldo> Conceptos { get; set; }
    }
}