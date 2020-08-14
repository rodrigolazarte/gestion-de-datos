using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Xml.Schema;
using viabana_nuevo.Models;

namespace viabana_nuevo.Controllers
{
    public class Modelo
    {
        public static List<LineaDeVenta> ListaLDV { get; set; }
        public static double SubTotal { get; set; }
    }
    public class VentaController : Controller
    {
        
        [HttpPost]
        public ActionResult Venta(List<LineaDeVenta> lista)
        {
            float subtotal = 0;
            foreach(var lineaDeVenta in lista)
            {
                lineaDeVenta.BuscarProducto();
                subtotal += lineaDeVenta.Subtotal;
            }
            
            ViewBag.Categorias = GeneradorDatos.GenerarCategorias();
            Modelo.ListaLDV = lista;
            Modelo.SubTotal = subtotal;
            return View("Venta");

        }
        // GET: Venta
        [HttpGet]
        public ActionResult Venta()
        {
            ViewBag.Subtotal = Modelo.SubTotal;
            ViewBag.Categorias = GeneradorDatos.GenerarCategorias();
            return View(Modelo.ListaLDV);
        }

        public ActionResult SeleccionarCategoria(int Id)
        {
            var listaProductos = Producto.filtrarPorCategoria(Id);
            return View("Partials/_ListaProductos", listaProductos);
        }

        [HttpPost]
        public ActionResult AceptarVenta(List<LineaDeVenta> lista)
        {
            foreach(var lineaDeVenta in lista)
            {
                lineaDeVenta.BuscarProducto();
            }
            Modelo.ListaLDV = lista;
            var subtotal = 0;
            foreach(var lineaDeVenta in lista)
            {
                subtotal += lineaDeVenta.Subtotal;
            }

            Modelo.SubTotal = subtotal;
            return View(lista);
        }

        [HttpGet]
        public ActionResult AceptarVenta()
        {
            ViewBag.Total = Modelo.SubTotal;
            return View(Modelo.ListaLDV);
        }
    }
}