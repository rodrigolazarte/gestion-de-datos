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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConceptoCategoriaEmpleado>().HasKey(x => new { x.ConceptoId, x.CategoriaEmpleadoId});

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Concepto> Conceptos { get; set; }
        public DbSet<DetalleConcepto> DetalleConceptos { get; set; }
        public DbSet<DetalleNovedad> DetalleNovedades { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CategoriaEmpleado> CategoriaEmpleados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaUsuario> CuentaUsuarios { get; set; }
        public DbSet<DetalleLiquidacion> DetalleLiquidacions { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<LineaDeVenta> LineaDeVentas { get; set; }
        public DbSet<Liquidacion> Liquidacions { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<RolEmpleado> RolEmpleados { get; set; }
        public DbSet<TipoCliente> TipoClientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ConceptoCategoriaEmpleado> ConceptoCategoriaEmpleados { get; set; }

    }
}