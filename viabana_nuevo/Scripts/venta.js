/// <reference path="jquery-3.3.1.js" />

$(document).ready(function () {
    $(".linkProductos").click(function () {
        var url = $(this).data('url');
        $("#listaProductosVenta").load(url)
    })
})

//Agrega producto seleccionado de la tabla de _ListaProductos
$(document).ready(function () {
    $(".agregarProducto").on("click", function (e) {
        e.stopImmediatePropagation();
        let id = $(this).data("id");
        let nombre = $(this).data("nombre");
        let precio = $(this).data("precio");
        let cantidad = $(this).parents("tr").find(".inputCantidad").val();
        if (cantidad <= 0 || isNaN(cantidad)) {
            alert("Ingrese un valor numérico mayor a 0");
            $(this).parents("tr").find(".inputCantidad").attr({ "class": "inputCantidad alertaInvalido", "title": "No puede ingresar un valor nulo o negativo" }).focus();
        }
        if(cantidad > 0){
            var insert =
                '<tr><td width="10%">' + id
                + '</td><td width="35%">' + nombre
                + '</td><td width="15%" class="precio">' + precio
                + '</td><td width="15%">' + cantidad
                + '</td><td width="15%">' + cantidad * precio
                + '</td><td width="10%">' + '<span class="glyphicon glyphicon-erase btnEliminarProducto"></span>' +
                '</td></tr>';
            $(".tablaCargaProductos tbody").append(insert);
        }
        
    })
})

//Actualizar el valor del subtotal de la venta cuando cambia la tabla
$(document).ready(function () {
    $('#bodyTableProductos').on("DOMNodeInserted", function (e) {
        e.preventDefault();
        e.stopImmediatePropagation();
        var subtotal = 0;
        $('#bodyTableProductos tr').each(function () {
            subtotal += $(this).find('td:eq(2)').text() * $(this).find('td:eq(3)').text();
            console.log(subtotal);
        });
        $("#totalCompra").val(subtotal);
    });
});

//Actualizar valor del subtotal de la venta al eliminar un producto de la tabla
$(".tablaCargaProductos").on('click', 'span.btnEliminarProducto', function (e) {
    e.stopImmediatePropagation();
    var precio = $(this).parents("tr").find("td:eq(4)").text();
    var subtotal = $("#totalCompra").val();
    subtotal -= precio;
    $("#totalCompra").val(subtotal);
    $(this).parent().parent().remove();
});

$(document).keypress(function (e) {
    if (e.keyCode == 13) {
        $(".botonAceptar").click();
    }
});

//Método POST que envia los productos al controlador de Ventas
$('.botonAceptar').click(function (e) {
    e.preventDefault();
    e.stopImmediatePropagation();
    var lista = [];
    var url = $(this).data("url");
    $('.tablaCargaProductos tbody tr').each(function () {
        var id = $(this).find('td:eq(0)').text();
        var cantidad = $(this).find('td:eq(3)').text();
        var subtotal = $(this).find('td:eq(4)').text();
        lista.push({ IdProducto: id, Cantidad: cantidad, Subtotal: subtotal });
    });

    var data = { lista: lista }

    $.post(url, data).done(function () {
        location.replace(url);
    });
});

//Agrega un descuento a la tabla de descuentos
$("#agregarDescuento").on("click", function () {
    let montoDescuento = $("#montoDescuento").val();
    let descripcionDescuento = $("#descripcionDescuento").val();
    let tipoDescuento = $('input[name="descuento"]:checked').val();
    let simboloDescuento = "";
    let subtotalVenta = $("#subtotalVenta").val();
    let totalConDescuento = $("#totalVenta").val();
    if (tipoDescuento == "efectivo") {
        simboloDescuento = "$"
        totalConDescuento -= montoDescuento;
        $("#totalVenta").val(totalConDescuento);
    }
    if (tipoDescuento == "porcentaje") {
        simboloDescuento = "%"
        let aux = subtotalVenta * montoDescuento / 100;
        totalConDescuento -= aux;
        $("#totalVenta").val(totalConDescuento);
    }

    var insert = "<li class='list-group-item list-group-item-info'>" +
        "<span id='simbolo'>" + simboloDescuento + "</span>" +
        "<span id='monto'>" + montoDescuento + "</span>" +
        "<span class='glyphicon glyphicon-erase botonEliminar' style='float: right; margin-left: 10px' data-tipoDescuento='" + tipoDescuento + "' data-montoDescuento='" + montoDescuento + "'>" +
        "</span>" +
        "<span class='glyphicon glyphicon-info-sign' style='float: right; position: relative' data-toggle='tooltip' data-placement= 'right' title=" + descripcionDescuento + ">" +
        "</span>" +
        "</li>"

    $("#listaDescuentos").append(insert);
});

$("#listaDescuentos").on("click", "span.botonEliminar", function (e) {
    e.stopImmediatePropagation();
    let montoDescuento = parseFloat($(this).parent("li").find("#monto").text());
    let tipoDescuento = $(this).parent("li").find("#simbolo").text();
    var totalConDescuento = parseFloat($("#totalVenta").val());
    console.log(montoDescuento + tipoDescuento + totalConDescuento);

    if (tipoDescuento == "%") {
        let subtotalVenta = $("#subtotalVenta").val();
        let aux = subtotalVenta * montoDescuento / 100;
        totalConDescuento += aux;
        $("#totalVenta").val(totalConDescuento);
    }
    if (tipoDescuento == "$") {
        totalConDescuento += montoDescuento;
        $("#totalVenta").val(totalConDescuento);
    }
    $(this).parent().remove();
});

//Habilitar el tooltip de bootstrap
$(function () {
    $('[data-toggle="tooltip"]').tooltip();
});

$("#botonFinalizar").click(function () {

});

$("#editarVenta").click(function (e) {
    e.preventDefault();
    e.stopImmediatePropagation();

    var lista = [];
    var url = $(this).data("url");
    $('.tablaCargaProductos tbody tr').each(function () {
        var id = $(this).find('td:eq(0)').text();
        var cantidad = $(this).find('td:eq(3)').text();
        var subtotal = $(this).find('td:eq(4)').text();
        lista.push({ IdProducto: id, Cantidad: cantidad, Subtotal: subtotal });
    });

    var data = { lista: lista }
    $.post(url, data).done(function () {
        location.replace(url);
    });
});