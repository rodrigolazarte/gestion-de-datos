/// <reference path="jquery-3.3.1.js" />

$(document).ready(function () {
    $("#agregarCompra").click(function () {
        var url = $(this).data('url');
        $("#nuevaCompra").load(url);
    }) 
})

$(document).ready(function () {
    $("#botonVerProductos").click(function () {
        var index = $('#listaProveedores option:selected').text();
        var url = $(this).data('url');
        url = url.replace("param-index", index)
        $("#listaProductos").load(url);
    })
})