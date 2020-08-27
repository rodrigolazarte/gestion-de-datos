using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viabana_nuevo.Models;

namespace viabana_nuevo.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Personal()
        {
            var listaEmpleados = GeneradorDatos.GenerarEmpleados();
            return View(listaEmpleados);
        }

        public ActionResult Novedades(int idEmpleado)
        {
            var listaEmpleados = GeneradorDatos.GenerarEmpleados();
            var empleado = listaEmpleados.Find(x => x.Legajo == idEmpleado);
            ViewBag.Empleado = empleado;

            var listaNovedades = GeneradorDatos.GenerarNovedades();

            return View(listaNovedades);
        }

        public ActionResult EditarEmpleado(int idEmpleado)
        {
            var listaEmpleados = GeneradorDatos.GenerarEmpleados();
            var empleado = listaEmpleados.Find(x => x.Legajo == idEmpleado);


            return View(empleado);
        }
    }
}