using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viabana_nuevo.Models;

namespace viabana_nuevo.Controllers
{
    public class VentaController : Controller
    {
        // GET: Venta
        public ActionResult Venta()
        {
            var categoria1 = new Categoria();
            var categoria2 = new Categoria();
            var categoria3 = new Categoria();
            var categoria4 = new Categoria();
            var categoria5 = new Categoria();
            var categoria6 = new Categoria();

            categoria1.Descripcion = "Bombones";
            categoria1.Id = 1;
            categoria1.UrlImagen = "/Images/Bombon.png";

            categoria2.Descripcion = "Cucuruchos";
            categoria2.Id = 2;
            categoria2.UrlImagen = "/Images/cucuruchos.jpg";

            categoria3.Descripcion = "Kilo";
            categoria3.Id = 3;
            categoria3.UrlImagen = "/Images/Kilo.jpg";

            categoria4.Descripcion = "Bombones";
            categoria4.Id = 1;
            categoria4.UrlImagen = "/Images/Bombon.png";

            categoria5.Descripcion = "Cucuruchos";
            categoria5.Id = 2;
            categoria5.UrlImagen = "/Images/cucuruchos.jpg";

            categoria6.Descripcion = "Kilo";
            categoria6.Id = 3;
            categoria6.UrlImagen = "/Images/Kilo.jpg";

            var listaCategorias = new List<Categoria>();

            listaCategorias.Add(categoria1);
            listaCategorias.Add(categoria2);
            listaCategorias.Add(categoria3);
            listaCategorias.Add(categoria4);
            listaCategorias.Add(categoria5);
            listaCategorias.Add(categoria6);
            listaCategorias.Add(categoria3);
            listaCategorias.Add(categoria3);

            ViewBag.Categorias = listaCategorias;

            return View();
        }

        public ActionResult SeleccionarCategoria(int Id)
        {
            var listaProductos = new List<Producto>();
            if(Id == 1)
            {
                var producto = new Producto();
                producto.Descripcion = "Bombon Escoces";
                producto.UrlImagen = "https://viabana.com.ar/wp-content/uploads/2015/08/escoces.png";
                producto.Id = 1;
                listaProductos.Add(producto);

                var producto2 = new Producto();
                producto2.Descripcion = "Via Bom";
                producto2.UrlImagen = "https://viabana.com.ar/wp-content/uploads/2015/08/via_bon.png";
                producto2.Id = 2;
                listaProductos.Add(producto2);


                ViewBag.Productos = listaProductos;
            }
            if(Id == 2)
            {
                var producto = new Producto();
                producto.Descripcion = "Cucurucho con dos bochas";
                listaProductos.Add(producto);
                ViewBag.Productos = listaProductos;
            }
            if(Id == 3)
            {
                var producto = new Producto();
                producto.Descripcion = "Kilo de helado";
                listaProductos.Add(producto);
                ViewBag.Productos = listaProductos;
            }

            return View("Partials/_ListaProductos");
        }
    }
}