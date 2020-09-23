using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viabana_nuevo.Models;
using viabana_nuevo.Servicios;

namespace viabana_nuevo.Controllers
{
    public class ViewModelCategoriaDeEmpleado
    {
        public int IdCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public float MontoSueldoBasico { get; set; }
        public List<Concepto> ConceptosDeSueldo { get; set; }
        
    }
    public class ConceptosController : Controller
    {
        private readonly IRepositorio<Concepto> _repoConcepto;
        private readonly IRepositorio<CategoriaEmpleado> _repoCategoria;
        private readonly IRepositorioConceptoCategoria _repoConceptoCategoria;

        public ConceptosController(IRepositorio<Concepto> repoConcepto, IRepositorio<CategoriaEmpleado> repoCategoria, IRepositorioConceptoCategoria repoConceptoCategoria)
        {
            this._repoConcepto = repoConcepto;
            this._repoCategoria = repoCategoria;
            this._repoConceptoCategoria = repoConceptoCategoria;
        }
        // GET: Conceptos
        public ActionResult Categorias()
        {
            var listaCategorias = _repoCategoria.Listar();
            //var listaCategorias = GeneradorDatos.GenerarCategoriasEmpleados();
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
            var listaConceptos = _repoConcepto.Listar();
            //var listaConceptos = GeneradorDatos.GenerarConceptos().Concat(GeneradorDatos.GenerarNovedades()).ToList();
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
            _repoConcepto.Guardar(concepto);
            return RedirectToAction("VerConceptos");
        }

        [HttpGet]
        public ActionResult AgregarNuevaCategoria()
        {
            var modelo = new ViewModelCategoriaDeEmpleado();
            modelo.ConceptosDeSueldo = /*GeneradorDatos.GenerarConceptos();*/
                _repoConcepto.Listar();
            return View(modelo);
        }

        [HttpPost]
        public ActionResult AgregarNuevaCategoria(ViewModelCategoriaDeEmpleado modelo)
        {
            if(modelo.ConceptosDeSueldo != null)
            {
                var categoria = new CategoriaEmpleado();
                categoria.Descripcion = modelo.DescripcionCategoria;
                categoria.SueldoBasico = modelo.MontoSueldoBasico;
                _repoCategoria.Guardar(categoria);
                categoria.Conceptos = modelo.ConceptosDeSueldo;
                _repoConceptoCategoria.AsociarConceptosACategoria(categoria);
                return RedirectToAction("Categorias");
            }
            else
            {
                return View(modelo);
            }

        }

        [HttpGet]
        public ActionResult EditarCategoria(int id)
        {
            var categoria = _repoCategoria.BuscarPorId(id);
            var modelo = new ViewModelCategoriaDeEmpleado();
            var conceptos = new List<Concepto>();
            var items = _repoConceptoCategoria.BuscarConceptosDeCategoria(id);
            foreach(var item in items) 
            {
                conceptos.Add(item.Concepto);
            }
            modelo.DescripcionCategoria = categoria.Descripcion;
            modelo.MontoSueldoBasico = categoria.SueldoBasico;
            modelo.ConceptosDeSueldo = conceptos;
            modelo.IdCategoria = id;

            return View(modelo);
        }

        [HttpPost]
        public ActionResult EditarCategoria(ViewModelCategoriaDeEmpleado modelo, int id)
        {
            var categoria = new CategoriaEmpleado();
            var items = new List<ConceptoCategoriaEmpleado>();
            categoria.Id = id;
            categoria.Descripcion = modelo.DescripcionCategoria;
            categoria.SueldoBasico = modelo.MontoSueldoBasico;
            _repoCategoria.Actualizar(categoria);
            _repoConceptoCategoria.Actualizar(modelo.ConceptosDeSueldo, id);
            return RedirectToAction("VerConceptos");
        }

        public ActionResult EliminarCategoria(int id)
        {
            _repoCategoria.Eliminar(id);
            _repoConceptoCategoria.Eliminar(id);
            return RedirectToAction("Categorias");
        }

        [HttpGet]
        public ActionResult EditarConcepto(int id)
        {
            var modelo = _repoConcepto.BuscarPorId(id);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult EditarConcepto(Concepto concepto)
        {
            _repoConcepto.Actualizar(concepto);
            return RedirectToAction("VerConceptos");
        }

        public ActionResult EliminarConcepto(int id)
        {
            _repoConcepto.Eliminar(id);
            return RedirectToAction("VerConceptos");
        }
    }
}