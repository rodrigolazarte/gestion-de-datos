/// <reference path="jquery-3.3.1.js" />

$(document).ready(function () {
    $("#btnGuardar").click(function (e) {
        e.preventDefault();
        e.stopImmediatePropagation();
        let descripcion = $("#Descripcion").val();
        let periodo = $("#Periodo").val();
        let categoria = $("#Categoria :selected").val();
        var lista = [];

        $("#listaEmpleados tbody tr").each(function () {
            var liquidar = $(this).find(".liquidar").val();
            if (liquidar == "true") {
                var id = $(this).find("td:eq(0)").text();
                var dias = $(this).find(".diasTrabajados").val();
                var linea = { Id: id, DiasTrabajados: dias };
                lista.push(linea);
            } 
        })
        let url = $(this).data("url");

        var data = { Descripcion: descripcion, Periodo: periodo, CategoriaEmpleado: categoria, ListaEmpleados: lista }
        $.post(url, data);
    });
});

$(document).ready(function () {
    $("#cargarEmpleados").click(function () {
        var url = $(this).data("url");
        var idCategoria = $("#Categoria :selected").val();
        url = url.replace("param-index", idCategoria)
        $("#listaEmpleados").load(url);
    });
});

$(".liquidar").click(function () {
    if ($(this).val() == "false") {
        $(this).val("true");
    } else {
        $(this).val("false");
    }
})

$(document).ready(function () {
    $(".btnVerDetalle").click(function () {
        var url = $(this).data("url");
        $("#detalleLiquidacion").load(url);
    });
});