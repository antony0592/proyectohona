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
                    if (result != null) {
                        $("#clientname").val(result.name);
                        $("#clientlastname").val(result.lastname);
                        $("#clientemail").val(result.email);
                        $("#paypalemail").val(result.email);
                        $("#welcomeback").html("Gracias por reservar nuevamente con nosotros: <br/> <small> " + result.name + " " + result.lastname + "</small> <br/>");
                    }
                    
                },

                error: function (errorMessage) {
                    alert(errorMessage.responseText);
                }
            });
        } else {
            $("#clientname").val("");
            $("#clientlastname").val("");
            $("#clientemail").val("");
            $("#paypalemail").val("");
            $("#welcomeback").html("");
        }
    });

    $("#payment").on("click", function (e) {

        client = {
            id: $("#idnumber").val(),
            name: $("#clientname").val(),
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

//Login Paypal
$(document).ready(function () {

    $('form').on('click', '#loginpaypal', function (e) {
        e.preventDefault();
        var email = $("#paypalemail").val();
        var password = $("#paypalpassword").val();

        if (email.trim() == "" || password.trim() == "") {
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
                $("#clientnameinpaypal").html($("#clientname").val());
                $("#totalfinalpaypal").html($("#totalamount").val());
                //$("#totalfinalpaypal").html('000');

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

//Search Room
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
                    var totalamount = result[0].amount;
                    localStorage.clear();
                    localStorage.setItem("totalamount", totalamount);
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
                            '<td><button class="btn btn-success btn-lg" type="button" onclick="return GetById(\'' + result[i].id + '\')">Reservar</button></td>' +
                            "<tr>";
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

//Pay whith pay Pal
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
            success: function (result) { },
            error: function (errorMessage) {
                // alert(errorMessage.responseText);
            }
        });
    });
});

function GetById(id) {

    var arrivaldate = document.getElementById("arrivaldate").value;
    var departuredate = document.getElementById("departuredate").value;

    
    localStorage.setItem("arrivaldate", arrivaldate);
    localStorage.setItem("departuredate", departuredate);
    localStorage.setItem("idroom", id);

    $.ajax({
        url: "/Reservation/GetRoomById",
        type: "GET",
        data: { 'id': id },
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        //data: dataObject,
        success: function (result) {

            var url = 'Data/' + result;
            window.location.href = url;



        },
        error: function (errorMessage) {
            //alert(errorMessage.responseText);
        }
    });
}

$(document).ready(function () {

    if (localStorage.getItem("arrivaldate") && localStorage.getItem("departuredate")) {
        var arrivaldate = localStorage.getItem("arrivaldate");
        var departuredate = localStorage.getItem("departuredate");
        var resta = new Date(departuredate).getTime() - new Date(arrivaldate).getTime();
        var datequantity = Math.round(resta / (1000 * 60 * 60 * 24));
        var totalamount = localStorage.getItem("totalamount");
        $("#arrivaldateF").val(arrivaldate);
        $("#departuredateF").val(departuredate);
        $("#days").val(datequantity);
        $("#totalamount").val(totalamount * datequantity);
        $("#amountperday").text(totalamount);
        $("#dayamount").val(totalamount);
        $("#idroomF").val(localStorage.getItem("idroom"));
    }


});

//Pay confirmation
$(document).ready(function () {

    $('form').on('click', '#PayConfirmation', function (e) {

        var PaymentCard = {
            id: "0",
            cardname: $("#cardname").val(),
            cvv: $("#PaymentCardCvv").val(),
            cardtype: "",
            cardnumber: $("#PaymentCardNumber").val(),
            expirationdate: $("#PaymentCardDate").val()
        };

        var inWhite = isNull(PaymentCard);
        if (inWhite.length > 1) {
            $("#paypalerror2").html("Debe de llenar todos los datos");
        } else {
            e.preventDefault();
            PaymentCard.cardtype = "PayPal";
            $.ajax({
                url: "/PaymentCard/AddPaymentCard",
                data: PaymentCard,
                type: "POST",
                success: function (result) {
                    if (result != null) {

                        $("#formpay").hide();
                        $(this).closest(".modal-body").append("<img id='loader' src='/images/loader.gif' />");
                        $(this).animate({
                            opacity: 0.5
                        }, 2000, function () {
                            $(this).closest(".modal-body").find("img#loader").hide();
                            $("#message").html("Pago Realizado con exito");
                            $("#payment").hide();
                            $("#paymentcardid").val(result.id);

                            $("#paymentModal").modal("hide");
                            $("#paymentConfirmation").show();
                        });

                    } else {
                        alert("Error.Por favor intente de nuevo");
                    }
                },
                error: function (errorMessage) {
                    alert("Error.Por favor intente de nuevo");
                }
            });
        }
    });
});

$(document).ready(function () { $("#paymentConfirmation").hide(); });

$(document).ready(function () {
    $("#idnumber").ForceNumericOnly();
    $("#PaymentCardNumber").ForceNumericOnly();
    $("#PaymentCardDate").ForceNumericOnly();
    $("#PaymentCardCvv").ForceNumericOnly();
});

// Numeric only control handler
jQuery.fn.ForceNumericOnly =
    function () {
        return this.each(function () {
            $(this).keydown(function (e) {
                var key = e.charCode || e.keyCode || 0;
                // allow backspace, tab, delete, enter, arrows, numbers and keypad numbers ONLY
                // home, end, period, and numpad decimal
                return (
                    key == 8 ||
                    key == 9 ||
                    key == 13 ||
                    key == 46 ||
                    key == 110 ||
                    key == 190 ||
                    (key >= 35 && key <= 40) ||
                    (key >= 48 && key <= 57) ||
                    (key >= 96 && key <= 105));
            });
        });
    };









