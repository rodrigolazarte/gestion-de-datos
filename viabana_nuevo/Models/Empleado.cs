using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace viabana_nuevo.Models
{
    public class Empleado : Persona
    {
        public Domicilio Domicilio { get; set; }
        public TipoEmpleado TipoEmpleado { get; set; }
        public bool Estado { get; set; }
        public RolEmpleado RolEmpleado { get; set; }
        public List<Persona> GrupoFamiliar { get; set; }
        public List<Novedad> Novedades { get; set; }
        public List<EmpleadoLiquidacion> EmpleadosLiquidaciones { get; set; }
    }
}