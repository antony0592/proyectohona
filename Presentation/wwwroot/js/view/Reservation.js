//Document ready
var client;
$(document).ready(function () {

    $("#idnumber").keyup(function (e) {
        e.preventDefault();
        var id = $(this).val();
        if (id.length == 9) {
            $.ajax({
                url: "/Reservation/GetClientById/" + id,
                type: "GET",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (result) {
                    $("#clientname").val(result.name);
                    $("#clientlastname").val(result.lastname);
                    $("#clientemail").val(result.email);
                    $("#paypalemail").val(result.email);
                    $("#welcomeback").html("Gracias por reservar nuevamente con nosotros: <br/> <small> " + result.name + " " + result.lastname +"</small> <br/>");
                },

                error: function (errorMessage) {
                    alert(errorMessage.responseText);
                }
            });
        }
    });

    $("#payment").on("click", function (e) {

        client = {
            id: $("#idnumber").val(),
            name: $("clientname").val(),
            lastname: $("#clientlastname").val(),
            email: $("#clientemail").val()
        };

        var inWhite = isNull(client);

        if (inWhite.length == 0) {
            e.preventDefault();
            $('#paymentModal').modal("show");
          
        } else {
            $("#errorpayment").val("Datos invalidos");

        }
    });

});

$(document).ready(function () {

    $('form').on('click', '#loginpaypal', function (e) {
        e.preventDefault();
        var email = $("#paypalemail").val();
        var password = $("#paypalpassword").val();

        if (email.trim() == "" || password.trim() == "" ) {
            $("#paypalerror").html("Datos inválido");
        } else {
            $("#formpaypal").hide();
            $(this).closest(".modal-body").append("<img id='loader' src='/images/loader.gif' />");
            $(this).animate({
                opacity: 0.5
            }, 2000, function () {
                $(this).closest(".modal-body").find("img#loader").hide();
                    $("#formpay").show();
                    $("#clientemailinpaypal").html($("#clientemail").val());
                    $("#clientnameinpaypal").html($("#clientename").val());
            });
        }
    });
});

function isNull(object) {

    var inWhite = [];
    var cont = 0;
    for (const property in object) {

        try {
            if (object[property].trim() == "") {
                inWhite[cont] = property;
                cont++;
            }
        } catch (error) {
        }
    }
    return inWhite;
}


$(document).ready(function () {
    $("#searchroom").on("click", function (e) {
        e.preventDefault();

        $.ajax({
            url: "/Reservation/Getsearchroom/",
            type: "GET",
            data: { 'date1': $('#arrivaldate').val(), 'date2': $('#departuredate').val(), 'typeroom': $('#typeroomcb').val() },
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                $("#bodytable").html("");//limpia tabla
                if (result) {
                    for (var i = 0; i < result.length; i++) {
                        $("#amountsumit").val(result[i].amount);
                        $("#roomsumit").val(result[i].typeroom);
                        $("#roomdescriptionsumit").val(result[i].descriptiontyperoom);
                        $("#urlimagesumit").val(result[i].urlimage);
                        var tr = "<tr>" +
                            "<td>" + result[i].typeroom + "</td>" +
                            "<td>" + result[i].number + "</td>" +
                            "<td>" + result[i].quantityperson + "</td>" +
                            "<td>" + result[i].quantitybed + "</td>" +
                            "<td>" + result[i].amount + "</td>" +
                            "<td><button class='btn btn-success btn - lg' type='submit'>Reservar</button></td>" +
                            "<tr>" +
                            $("#bodytable").append(tr);
                        if (result[i].idtyperoom == $('#typeroomcb').val()) {
                                $("#alert").html("Hemos encontrado esta habitación para ti:");
                            } else { $("#alert").html("NO HEMOS ENCONTRADO TU HABITACIÓN PERO ENCONTRAMOS ESTA OTRA DISPONIBLE:"); }
                    }
                }
                if (!result) {
                    $("#alert").html("SIN RESULTADOS");
                    var tr = "<tr>" +
                        "<td>--</td>" +
                        "<td>--</td>" +
                         "<td>--</td>" +
                        "<td>--</td>" +
                        "<td>--</td>" +
                        "<td><button class='btn btn-success btn - lg' type='submit'>Reservar</button></td>" +
                        "<tr>" +
                        $("#bodytable").append(tr);
                }

            },

                error: function (errorMessage) {
                    alert(errorMessage.responseText);
                }
            });
    });
});



$(document).ready(function () {
    $("#gopay").on("click", function (e) {
        e.preventDefault();
        $.ajax({
            url: "/Reservation/Data",
            type: "GET",
            data: { 'precio': $('#amountsumit').val() },
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            //data: dataObject,
            success: function (result) {},
            error: function (errorMessage) {
                alert(errorMessage.responseText);
            }
        });
    });
});
