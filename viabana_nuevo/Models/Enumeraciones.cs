using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class Enumeraciones
    {
        public enum TipoConcepto
        {
            Sueldo = 0,
            Novedad = 1
        }
        public enum Unidad
        {
            Unidad = 0,
            Porcentaje = 1
        }

        public enum Efecto
        {
            Remuneracion = 0,
            Descuento = 1,
        }
    }
}