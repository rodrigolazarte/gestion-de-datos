using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace viabana_nuevo.Models
{
    public class Empleado : Persona
    {
        [Key]
        [Column(Order=2)]
        public int Legajo { get; set; }
        public Domicilio Domicilio { get; set; }
        public CategoriaEmpleado CategoriaEmpleado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public CuentaUsuario CuentaUsuario { get; set; }
        public bool Estado { get; set; }
        public RolEmpleado RolEmpleado { get; set; }
        public List<Familiar> GrupoFamiliar { get; set; }
        public List<DetalleNovedad> DetallesNovedades { get; set; }

    }
}