using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Servicios
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity :class
    {
        public void Guardar(TEntity objeto)
        {
            using (var contexto = new Models.ViaBanaDbContext())
            {
                contexto.Set<TEntity>().Add(objeto);
                contexto.SaveChanges();
            }
        }

        public List<TEntity> Listar()
        {
            using (var contexto = new Models.ViaBanaDbContext())
            {
                return contexto.Set<TEntity>().ToList();
            }
        }

        public TEntity BuscarPorId(int id)
        {
            using (var contexto = new Models.ViaBanaDbContext())
            {
                return contexto.Set<TEntity>().Find(id);
            }
        }

        public void Actualizar(TEntity entidad)
        {
            using (var contexto = new Models.ViaBanaDbContext())
            {
                contexto.Entry(entidad).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var contexto = new Models.ViaBanaDbContext())
            {
                var eliminar = contexto.Set<TEntity>().Find(id);
                contexto.Set<TEntity>().Remove(eliminar);
                contexto.SaveChanges();
            }
        }
    }
}