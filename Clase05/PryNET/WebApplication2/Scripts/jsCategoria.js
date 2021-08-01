$(document).ready(function () {
    console.log("Ingresó Categoría");
});

function modalCrearCategoria() {
    $("#modalPopup").removeClass("modal-lg");
    $("#modalPopup").removeClass("modal-xs");
    $("#modalPopup").removeClass("modal-md");
    $("#modalPopup").removeClass("modal-sm");
    $("#modalPopup").addClass("modal-md");

    $.ajax({
        type: 'GET',
        url: '/Categoria/New',
        beforeSend: function () {
        },
        success: function (data) {
            $("#headerModal").html("Registrar Categoría - Cabecera");
            $("#bodyModal").html(data);
            //$("#btnGrabarModal").show();
            $("#footerModal").show();
            $('#myModal').modal();
        },
        error: function (data) {
            console.log(data);
        },
        complete: function () {
        }
    });
}