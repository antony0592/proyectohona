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
                    $("#welcomeback").html("Gracias por reservar nuevamente con nosotros: <br/> <small> " + result.name + " " + result.lastname + "</small> <br/>");
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
                            '<td><button class="btn btn-success btn-lg" type="button" onclick="return GetById(\'' + result[i].id + '\')">Reservar</button></td>' +
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
            success: function (result) { },
            error: function (errorMessage) {
               // alert(errorMessage.responseText);
            }
        });
    });
});

function GetById(id)     {

    var arrivaldate = document.getElementById("arrivaldate").value;
    var departuredate = document.getElementById("departuredate").value;

    localStorage.clear();
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

            var url = 'Data/'+result;
            window.location.href = url;

            
        
        },
        error: function (errorMessage) {
            //alert(errorMessage.responseText);
        }
    });
}

$(document).ready(function () {

    if (localStorage.getItem("arrivaldate") && localStorage.getItem("departuredate"))
    {
        var arrivaldate = localStorage.getItem("arrivaldate");
        var departuredate = localStorage.getItem("departuredate");
        var resta = new Date(departuredate).getTime() - new Date(arrivaldate).getTime();
        var datequantity = Math.round(resta / (1000 * 60 * 60 * 24));

        $("#arrivaldateF").val(arrivaldate);
        $("#departuredateF").val(departuredate);
        $("#days").val(datequantity);        
        $("#totalamount").val($("#dayamount").val() * datequantity );
        $("#idroomF").val(localStorage.getItem("idroom") );
    }

    

});

$(document).ready(function () {

    $('form').on('click', '#PayConfirmation', function (e) {
        e.preventDefault();

       
            var PaymentCard = {
                Id: "0",
                IdClient: $("#idnumber").val(),
                Cvv: $("#PaymentCardCvv").val(),
                Type: "PayPal",
                Number: $("#PaymentCardNumber").val(),
                Date: $("#PaymentCardDate").val()
        };

        


        if (PaymentCard.Cvv.trim() == "" || PaymentCard.Number.trim() == "" || PaymentCard.Date.trim() == "") {
            $("#paypalerror2").html("Debe de llenar todos los datos");
        } else {

            $.ajax({
                url: "/PaymentCard/AddPaymentCard",
                data: PaymentCard,
               // data: JSON.stringify(data),
                type: "POST",
                //contentType: "application/json;charset=utf-8",
               // dataType: "json",
                success: function (result) {
                    if (result > 0) {

                        $("#formpay").hide();
                        $(this).closest(".modal-body").append("<img id='loader' src='/images/loader.gif' />");
                        $(this).animate({
                            opacity: 0.5
                        }, 2000, function () {
                            $(this).closest(".modal-body").find("img#loader").hide();
                            $("#message").html("Pago Realizado con exito");
                            $("#payment").hide();

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








