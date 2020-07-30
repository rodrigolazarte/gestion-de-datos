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
        var insert = '<tr><td width="40%">' + descripcion
            + '</td><td width="15%" class="id">' + id
            + '</td><td width="15%">' + '1'
            + '</td><td width="20%">' + '200'
            + '</td><td width="10%">' + '<span class="glyphicon glyphicon-erase btnEliminarProducto"></span>' +
            '</td></tr>';
        $(".tablaCargaProductos tbody").append(insert);

    })
})

$(".tablaCargaProductos").on('click', 'span.btnEliminarProducto', function () {
    $(this).parent().parent().remove();
});

$('.botonAceptar').click(function (e) {
    e.preventDefault();
    e.stopImmediatePropagation();
    var lista = [];
    var url = $(this).data("url");
    $('.tablaCargaProductos tbody tr').each(function () {
        var descripcion = $(this).find('td:eq(0)').text();
        var cantidad = $(this).find('td:eq(2)').text();
        lista.push({ Descripcion: descripcion, Cantidad: cantidad });
    });

    var data = {lista: lista}
    console.log(data);

    $.post(url, data).done(function () {
        location.replace(url);
    });
});