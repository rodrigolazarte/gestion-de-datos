using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viabana_nuevo.Models;

namespace viabana_nuevo.Controllers
{
    public class ViewModelCategoriaDeEmpleado
    {
        public string DescripcionCategoria { get; set; }
        public float MontoSueldoBasico { get; set; }
        public List<Concepto>ConceptosDeSueldo { get; set; }
        
    }
    public class ConceptosController : Controller
    {
        // GET: Conceptos
        public ActionResult Categorias()
        {
            var listaCategorias = GeneradorDatos.GenerarCategoriasEmpleados();
            return View(listaCategorias);
        }

        public ActionResult VerConceptosDeCategoria(int id)
        {
            var listaCategorias = GeneradorDatos.GenerarCategoriasEmpleados();
            var categoria = listaCategorias.Find(x => x.Id == id);
            return View("Partials/_VerConceptosDeCategoria", categoria);
        }

        public ActionResult VerConceptos()
        {
            var listaConceptos = GeneradorDatos.GenerarConceptos().Concat(GeneradorDatos.GenerarNovedades()).ToList();
            return View(listaConceptos);
        }

        [HttpGet]
        public ActionResult AgregarNuevoConcepto()
        {
            ViewBag.TipoConcepto = Enumeraciones.TipoConcepto.Sueldo;
            return View();
        }

        [HttpPost]
        public ActionResult AgregarNuevoConcepto(Concepto concepto)
        {
            return RedirectToAction("VerConceptos");
        }

        [HttpGet]
        public ActionResult AgregarNuevaCategoria()
        {
            var modelo = new ViewModelCategoriaDeEmpleado();
            modelo.ConceptosDeSueldo = GeneradorDatos.GenerarConceptos();
            return View(modelo);
        }

        [HttpPost]
        public ActionResult AgregarNuevaCategoria(ViewModelCategoriaDeEmpleado modelo)
        {
            var listaconceptos = new List<Concepto>();
            var dbconceptos = GeneradorDatos.GenerarConceptos();
            var categoria = new CategoriaEmpleado();
            categoria.Descripcion = modelo.DescripcionCategoria;
            categoria.SueldoBasico = modelo.MontoSueldoBasico;

            foreach (var conceptosueldo in modelo.ConceptosDeSueldo)
            {
                listaconceptos.Add(dbconceptos.Find(concepto => concepto.Id == conceptosueldo.Id));
            }

            categoria.Conceptos = listaconceptos;

            return View();
        }

        [HttpGet]
        public ActionResult EditarCategoria(int id)
        {
            var categoria = GeneradorDatos.GenerarCategoriasEmpleados().Find(c => c.Id == id);
            var modelo = new ViewModelCategoriaDeEmpleado();
            modelo.DescripcionCategoria = categoria.Descripcion;
            modelo.MontoSueldoBasico = categoria.SueldoBasico;
            modelo.ConceptosDeSueldo = categoria.Conceptos;
            return View(modelo);
        }

        [HttpPost]
        public ActionResult EditarCategoria(ViewModelCategoriaDeEmpleado modelo)
        {
            return RedirectToAction("VerConceptos");
        }

        [HttpGet]
        public ActionResult EditarConcepto(int id)
        {
            var modelo = GeneradorDatos.GenerarConceptos().Find(x => x.Id == id);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult EditarConcepto(Concepto concepto)
        {
            return RedirectToAction("VerConceptos");
        }
    }
}