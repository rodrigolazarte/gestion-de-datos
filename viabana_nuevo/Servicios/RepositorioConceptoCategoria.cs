using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using viabana_nuevo.Models;
using viabana_nuevo.Controllers;
using System.Data.Entity;

namespace viabana_nuevo.Servicios
{
    public class RepositorioConceptoCategoria : IRepositorioConceptoCategoria
    {
        public void Actualizar(List<Concepto> conceptos, int id)
        {
            var items = new List<ConceptoCategoriaEmpleado>();
            using (var contexto = new ViaBanaDbContext())
            {
                items = contexto.ConceptoCategoriaEmpleados.Where(x => x.CategoriaEmpleadoId == id).ToList();
            }
            foreach (var item in items)
            {
                var borrar = true;
                foreach (var concepto in conceptos)
                {
                    if (item.ConceptoId == concepto.Id)
                    {
                        borrar = false;
                    }
                }
                if (borrar)
                {
                    using (var contexto = new ViaBanaDbContext())
                    {
                        var delete = contexto.ConceptoCategoriaEmpleados.First(x => x.CategoriaEmpleadoId == id && x.ConceptoId == item.ConceptoId);
                        contexto.ConceptoCategoriaEmpleados.Remove(delete);
                        contexto.SaveChanges();
                    }
                }
            }
        }

        public void AsociarConceptosACategoria(CategoriaEmpleado categoria)
        {
            using (var contexto = new ViaBanaDbContext())
            {
                foreach(var concepto in categoria.Conceptos)
                {
                    contexto.ConceptoCategoriaEmpleados.Add(new ConceptoCategoriaEmpleado { CategoriaEmpleadoId = categoria.Id, ConceptoId = concepto.Id});
                }
                contexto.SaveChanges();
            }
        }

        public List<ConceptoCategoriaEmpleado> BuscarConceptosDeCategoria(int id)
        {
            using (var contexto = new ViaBanaDbContext())
            {
                return contexto.ConceptoCategoriaEmpleados.Where(x => x.CategoriaEmpleadoId == id).Include(x => x.Concepto).ToList();
            }
        }

        public void Eliminar(int id)
        {
            using (var contexto = new ViaBanaDbContext())
            {
                contexto.ConceptoCategoriaEmpleados.RemoveRange(contexto.ConceptoCategoriaEmpleados.Where(x => x.CategoriaEmpleadoId == id));
                contexto.SaveChanges();
            }
        }
    }
}