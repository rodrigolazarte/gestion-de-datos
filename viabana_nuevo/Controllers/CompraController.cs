using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viabana_nuevo.Models;

namespace viabana_nuevo.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Compra()
        {
            var compra1 = new Compra();
            compra1.Id = 3;
            compra1.Proveedor = "Sancor";
            compra1.TotalCompra = 99;
            compra1.Fecha = "02/03/2020";

            var compra2 = new Compra();
            compra2.Id = 1;
            compra2.Proveedor = "Sancor2";
            compra2.TotalCompra = 993;
            compra2.Fecha = "03/03/2020";

            List<Compra> listaCompras = new List<Compra>();
            listaCompras.Add(compra1);
            listaCompras.Add(compra2);

            ViewBag.compras = listaCompras;

            return View("Compra");
        }

        public ActionResult NuevaCompra()
        {
            List<string> Proveedores = new List<string>();
            Proveedores.Add("Proveedor 1");
            Proveedores.Add("Proveedor 2");

            ViewBag.Proveedores = Proveedores;

            return PartialView("Partials/_NuevaCompra");
        }
    }
}