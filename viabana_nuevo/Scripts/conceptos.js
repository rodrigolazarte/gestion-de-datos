/// <reference path="jquery-3.3.1.min.js" />

$(document).ready(function () {
    $(".verConceptos").click(function () {
        var url = $(this).data("url");
        $("#listaConceptos").load(url);        
    });
});

$(document).ready(function () {
    $("#agregarConcepto").click(function (e) {
        e.preventDefault();
        e.stopImmediatePropagation();
        var validador = true;
        var codigo = $("#ConceptosDeSueldo option:selected").val();
        var descripcion = $("#ConceptosDeSueldo option:selected").text();
        var valor = $("#ConceptosDeSueldo option:selected").data("valor");
        var unidad = $("#ConceptosDeSueldo option:selected").data("unidad");

        $("#tablaConceptos tbody tr").find("#codigo").each(function () {
            if ($(this).text() == codigo) {
                validador = false;
                console.log(validador)
            }
        });
        
        if (validador) {
            var insert =
                "<tr><td id='codigo'>" + codigo + "</td>" +
                "<td>" + descripcion + "</td>" +
                "<td>" + valor + "</td>" +
                "<td>" + unidad + "</td>" +
                "<td><span class='glyphicon glyphicon-erase btnEliminar' style='color: #FF6631'></span></td></tr>"
            $("#tablaConceptos tbody").append(insert);
        }
        else {
            alert("No puede ingresar dos veces el mismo concepto")
        }
    })
})

$(document).ready(function () {
    $("#tablaConceptos").on("click", "span.btnEliminar", function () {
        $(this).parent().parent().remove();
    });
})

//Método POST de Categoría
$(document).ready(function () {
    $("#crearCategoria").click(function () {
        var DescripcionCategoria = $("#DescripcionCategoria").val();
        var DescripcionSueldoBasico = $("#DescripcionSueldoBasico").val();
        var MontoSueldoBasico = $("#MontoSueldoBasico").val();
        var lista = [];
        $("#tablaConceptos tbody tr").each(function () {
            var codigo = $(this).find("td:eq(0)").text();
            var descripcion = $(this).find("td:eq(1)").text();
            lista.push({ Id: codigo, Descripcion: descripcion });
        });
        var url = $(this).data("url");

        var data = { DescripcionCategoria: DescripcionCategoria, DescripcionSueldoBasico: DescripcionSueldoBasico, MontoSueldoBasico: MontoSueldoBasico, ConceptosDeSueldo: lista }
        console.log(data)
        $.post(url, data)
    });
});
