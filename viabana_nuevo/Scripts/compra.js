/// <reference path="jquery-3.3.1.js" />

$(document).ready(function () {
    $("#agregarCompra").click(function () {
        var url = $(this).data('url');
        $("#nuevaCompra").load(url);
    })
    
})