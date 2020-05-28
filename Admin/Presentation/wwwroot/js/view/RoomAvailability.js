
function SearchRoomAvailability() {

    $.ajax({
        url: "/AdministratorAvailability/SearchRoomAvailability",
        type: "GET",
        data: { 'date1': $('#arrivaldateA').val(), 'date2': $('#departuredateA').val(), 'typeRoom': $('#typeroomcbA').val() },
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            $("#bodytable").html("");//limpia tabla
            if (result) {
                for (var i = 0; i < result.length; i++) {
                    $("#amountsumit").val(result[i].amount);
                    $("#roomsumit").val(result[i].typeroom);
                    var tr = "<tr>" +
                        "<td>" + result[i].number + "</td>" +
                        "<td>" + result[i].typeroom + "</td>" +
                        "<td>" + result[i].amount + "</td>" +
                        "<tr>" +
                        $("#bodytable").append(tr);
                    if (result[i].idtyperoom == $('#typeroomcb').val()) {
                        $("#alert").html("Hemos encontrado estas habitaciónes para ti:");
                    } else { $("#alert").html("NO HEMOS ENCONTRADO TU HABITACIÓN PERO ENCONTRAMOS ESTA OTRA DISPONIBLE:"); }
                }
            }
            if (!result) {
                $("#alert").html("SIN RESULTADOS");
                var tr = "<tr>" +
                    "<td>--</td>" +
                    "<td>--</td>" +
                    "<td>--</td>" +
                    "<tr>" +
                    $("#bodytable").append(tr);
            }
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}