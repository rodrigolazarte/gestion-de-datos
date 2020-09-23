using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class Persona
    {
        [Key]
        [Column(Order = 1)]
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}