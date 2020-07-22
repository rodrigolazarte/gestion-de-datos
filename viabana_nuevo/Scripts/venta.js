/// <reference path="jquery-3.3.1.js" />

$(document).ready(function () {
    $(".linkProductos").click(function () {
        var url = $(this).data('url');
        $("#listaProductosVenta").load(url)
    })
})

$(document).ready(function () {
    $(".agregarProducto").click(function (e) {
        //e.preventDefault();
        e.stopImmediatePropagation();
        var id = $(this).data("id");
        var descripcion = $(this).data("descripcion");
        //alert("Usted ha seleccionado el producto " + id + " de nombre " + descripcion);
        console.log(id + descripcion);
    })
})