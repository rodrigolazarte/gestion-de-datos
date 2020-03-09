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
            Proveedores.Add("Proveedor1");
            Proveedores.Add("Proveedor2");

            ViewBag.Proveedores = Proveedores;

            return PartialView("Partials/_NuevaCompra");
        }

        public ActionResult ListaDeProductos(string index)
        {
            List<Producto> ListaProductos = new List<Producto>();
            var producto1 = new Producto();
            var producto2 = new Producto();

            producto1.Descripcion = "Producto 1";
            producto1.Id = 1;
            producto1.Precio = 90;
            producto1.Proveedor = "Proveedor1";

            producto2.Descripcion = "Producto 2";
            producto2.Id = 2;
            producto2.Precio = 190;
            producto2.Proveedor = "Proveedor2";

            ListaProductos.Add(producto1);
            ListaProductos.Add(producto2);

            List<Producto> listaFiltrada = ListaProductos.Where(x => x.Proveedor.Equals(index)).ToList();

            ViewBag.Productos = listaFiltrada;

            return PartialView("Partials/_ListaProductosDeProveedor");

        }
    }
}