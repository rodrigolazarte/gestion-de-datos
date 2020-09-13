using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public class ViaBanaDbContext: DbContext
    {
        public ViaBanaDbContext()
            :base("ViabanaDBConnection")
        {

        }
        public DbSet<Concepto> Conceptos { get; set; }
        public DbSet<DetalleConcepto> DetalleConceptos { get; set; }
        public DbSet<DetalleNovedad> DetalleNovedades { get; set; }
    }
}