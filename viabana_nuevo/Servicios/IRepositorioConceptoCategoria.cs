using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using viabana_nuevo.Models;

namespace viabana_nuevo.Servicios
{
    public interface IRepositorioConceptoCategoria
    {
        void AsociarConceptosACategoria(CategoriaEmpleado categoria);
        List<ConceptoCategoriaEmpleado> BuscarConceptosDeCategoria(int id);
        void Actualizar(List<Concepto> conceptos, int id);
        void Eliminar(int id);
    }
}
