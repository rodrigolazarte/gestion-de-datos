using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viabana_nuevo.Models;

namespace viabana_nuevo.Controllers
{
    public class DiasTrabajadosEmpleados
    {
        public int Id { get; set; }
        public int DiasTrabajados { get; set; }
    }
    public class ViewModelAgregarLiquidacion
    {
        public string Descripcion { get; set; }
        public DateTime Periodo { get; set; }
        public int CategoriaEmpleado { get; set; }
        public List<CategoriaEmpleado> ListaCategorias { get; set; }
        public List<DiasTrabajadosEmpleados> ListaEmpleados { get; set; }
    }
    public class LiquidacionController : Controller
    {
        // GET: Liquidacion
        public ActionResult Liquidaciones()
        {
            var liquidaciones = GeneradorDatos.GenerarLiquidaciones();
            return View(liquidaciones);
        }

        public ActionResult AgregarLiquidacion()
        {
            var modelo = new ViewModelAgregarLiquidacion();
            modelo.ListaCategorias = GeneradorDatos.GenerarCategoriasEmpleados();
            return View(modelo);
        }

        [HttpPost]
        public ActionResult GuardarLiquidacion(ViewModelAgregarLiquidacion modelo)
        {
            return View();
        }

        public ActionResult ListarEmpleadosALiquidar(int idCategoria)
        {
            var listaEmpleados = GeneradorDatos.GenerarEmpleados().FindAll(empleado => empleado.CategoriaEmpleado.Id == idCategoria);
            return View("Partials/_ListaEmpleadosALiquidar", listaEmpleados);
        }

        public ActionResult VerLiquidacion()
        {
            var modelo = GeneradorDatos.GenerarLiquidaciones()[0];
            return View(modelo);
        }

        public ActionResult MostrarDetalleLiquidacion(int id)
        {
            var detalleLiquidacion = GeneradorDatos.GenerarDetalleLiquidaciones().Find(x => x.Id == id);
            return View("Partials/_MostrarDetalleLiquidacion", detalleLiquidacion);
        }
    }
}