using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viabana_nuevo.Models
{
    public static class GeneradorDatos
    {
        public static List<Categoria> GenerarCategorias()
        {
            var listaCategorias = new List<Categoria>();

            var categoria1 = new Categoria();
            var categoria2 = new Categoria();
            var categoria3 = new Categoria();
            var categoria4 = new Categoria();
            var categoria5 = new Categoria();
            var categoria6 = new Categoria();
            var categoria7 = new Categoria();
            var categoria8 = new Categoria();
            var categoria9 = new Categoria();
            var categoria10 = new Categoria();

            categoria1.Descripcion = "Bombones";
            categoria1.Id = 1;
            categoria1.UrlImagen = "/Images/Bombon.png";

            categoria2.Descripcion = "Cucuruchos";
            categoria2.Id = 2;
            categoria2.UrlImagen = "/Images/cucuruchos.jpg";

            categoria3.Descripcion = "Kilo";
            categoria3.Id = 3;
            categoria3.UrlImagen = "/Images/Kilo.jpg";

            categoria4.Descripcion = "Bana Shake";
            categoria4.Id = 4;
            categoria4.UrlImagen = "https://viabana.com.ar/wp-content/uploads/2015/08/BanaShake.jpg";

            categoria5.Descripcion = "Capelina";
            categoria5.Id = 5;
            categoria5.UrlImagen = "https://viabana.com.ar/wp-content/uploads/2015/08/capelina-VB.jpg";

            categoria6.Descripcion = "Copas";
            categoria6.Id = 6;
            categoria6.UrlImagen = "https://viabana.com.ar/wp-content/uploads/2015/08/copa_obleas.jpg";

            categoria7.Descripcion = "Palitos";
            categoria7.Id = 7;
            categoria7.UrlImagen = "https://viabana.com.ar/wp-content/uploads/2015/08/palito_bombon1.jpg";

            categoria8.Descripcion = "Potes";
            categoria8.Id = 8;
            categoria8.UrlImagen = "https://viabana.com.ar/wp-content/uploads/2015/08/limon.jpg";

            categoria9.Descripcion = "Postres";
            categoria9.Id = 9;
            categoria9.UrlImagen = "https://viabana.com.ar/wp-content/uploads/2015/08/deliciaDedulceDeleche.jpg";

            categoria10.Descripcion = "Tortas";
            categoria10.Id = 10;
            categoria10.UrlImagen = "https://viabana.com.ar/wp-content/uploads/2015/08/torta_de_chocolate.jpg";

            listaCategorias.Add(categoria1);
            listaCategorias.Add(categoria2);
            listaCategorias.Add(categoria3);
            listaCategorias.Add(categoria4);
            listaCategorias.Add(categoria5);
            listaCategorias.Add(categoria6);
            listaCategorias.Add(categoria7);
            listaCategorias.Add(categoria8);
            listaCategorias.Add(categoria9);
            listaCategorias.Add(categoria10);

            return listaCategorias;

        }

        public static List<Producto> GenerarProductos() {
            var listaCategorias = GenerarCategorias();

            var listaProductos = new List<Producto>();

            var producto1 = new Producto();
            var producto2 = new Producto();
            var producto3 = new Producto();
            var producto4 = new Producto();
            var producto5 = new Producto();
            var producto6 = new Producto();
            var producto7 = new Producto();
            var producto8 = new Producto();
            var producto9 = new Producto();
            var producto10 = new Producto();
            var producto11 = new Producto();
            var producto12 = new Producto();
            var producto13 = new Producto();
            var producto14 = new Producto();
            var producto15 = new Producto();
            var producto16 = new Producto();
            var producto17 = new Producto();
            var producto18 = new Producto();

            producto1.Nombre = "Via Bom";
            producto1.Id = 1;
            producto1.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto1.Categoria = listaCategorias[0];
            producto1.Precio = 200;

            producto2.Nombre = "Bombon Escoces";
            producto2.Id = 2;
            producto2.Descripcion = "Helado de crema americana y crema helada sabor chocolate, relleno con dulce de leche, recubierto con baño de repostería y crocante de maní.";
            producto2.Categoria = listaCategorias[0];
            producto2.Precio = 220;

            producto3.Nombre = "Cucurucho 2 bochas";
            producto3.Id = 3;
            producto3.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto3.Categoria = listaCategorias[1];
            producto3.Precio = 100;

            producto4.Nombre = "Cucurucho 3 bochas";
            producto4.Id = 4;
            producto4.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto4.Categoria = listaCategorias[1];
            producto4.Precio = 130;

            producto5.Nombre = "1 Kg";
            producto5.Id = 5;
            producto5.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto5.Categoria = listaCategorias[2];
            producto5.Precio = 200;

            producto6.Nombre = "1/4 Kg";
            producto6.Id = 6;
            producto6.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto6.Categoria = listaCategorias[2];
            producto6.Precio = 80;

            producto7.Nombre = "bana Shake";
            producto7.Id = 7;
            producto7.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto7.Categoria = listaCategorias[3];
            producto7.Precio = 100;

            producto8.Nombre = "Capelina";
            producto8.Id = 8;
            producto8.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto8.Categoria = listaCategorias[4];
            producto8.Precio = 130;

            producto9.Nombre = "Copa Obleas";
            producto9.Id = 9;
            producto9.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto9.Categoria = listaCategorias[5];
            producto9.Precio = 120;

            producto10.Nombre = "Copa de chocolate";
            producto10.Id = 10;
            producto10.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto10.Categoria = listaCategorias[5];
            producto10.Precio = 120;

            producto11.Nombre = "Palito Frutilla";
            producto11.Id = 11;
            producto11.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto11.Categoria = listaCategorias[6];
            producto11.Precio = 90;

            producto12.Nombre = "Palito Bombon";
            producto12.Id = 12;
            producto12.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto12.Categoria = listaCategorias[6];
            producto12.Precio = 110;

            producto13.Nombre = "Limón 1LT";
            producto13.Id = 13;
            producto13.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto13.Categoria = listaCategorias[7];
            producto13.Precio = 200;

            producto14.Nombre = "Frutilla 1LT";
            producto14.Id = 14;
            producto14.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto14.Categoria = listaCategorias[7];
            producto14.Precio = 200;

            producto15.Nombre = "Cassata";
            producto15.Id = 15;
            producto15.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto15.Categoria = listaCategorias[8];
            producto15.Precio = 180;

            producto16.Nombre = "Delicia de dulce de leche";
            producto16.Id = 16;
            producto16.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto16.Categoria = listaCategorias[8];
            producto16.Precio = 200;

            producto17.Nombre = "Torta de chocolate";
            producto17.Id = 17;
            producto17.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto17.Categoria = listaCategorias[9];
            producto17.Precio = 340;

            producto18.Nombre = "Torta Via Bana";
            producto18.Id = 18;
            producto18.Descripcion = "Bombón helado sabor dulce de leche, recubierto con baño de repostería y arroz inflado.";
            producto18.Categoria = listaCategorias[9];
            producto18.Precio = 370;

            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);
            listaProductos.Add(producto4);
            listaProductos.Add(producto5);
            listaProductos.Add(producto6);
            listaProductos.Add(producto7);
            listaProductos.Add(producto8);
            listaProductos.Add(producto9);
            listaProductos.Add(producto10);
            listaProductos.Add(producto11);
            listaProductos.Add(producto12);
            listaProductos.Add(producto13);
            listaProductos.Add(producto14);
            listaProductos.Add(producto15);
            listaProductos.Add(producto16);
            listaProductos.Add(producto17);
            listaProductos.Add(producto18);

            return listaProductos;
        }
    }
}