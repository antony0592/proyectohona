//Document ready
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
        var client = {
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
                $("#conpay").show();
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