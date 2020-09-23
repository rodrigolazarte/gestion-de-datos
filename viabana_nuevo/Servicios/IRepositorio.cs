using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace viabana_nuevo.Servicios
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        void Guardar(TEntity entity);
        List<TEntity> Listar();
        TEntity BuscarPorId(int id);
        void Actualizar(TEntity entidad);
        void Eliminar(int id);
    }
}
