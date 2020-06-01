$(document).ready(function () {
    $("#description").on("click", function (e) {
        e.preventDefault();
        var dataObject = JSON.stringify({
            'input': $('#description').val()
        });

        $.ajax({
            url: "/AdministratorManageRooms/GetManageRooms",
            type: "GET",
            data: { 'description': $('#description').val() },
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            //data: dataObject,
            success: function (result) {
                console.log(result);
                if (result) {
                    $("#amount").val(result.amount);
                    $("#descriptionArea").html(" " + result.descriptiontyperoom + " ");
                    $("#image").attr("src", result.urlimage);
                }

                if (!result) {
                    $("#amount").html("-----");
                    $("#descriptionArea").html("-----");
                    $("#image").html("-----");
                }
            },
            error: function (errorMessage) {
                alert(errorMessage.responseText);
            }
        });
    });
});

$(document).on("click", "#updateRoom", function () {
    var div1 = document.getElementById('principal');
    var div2 = document.getElementById('manageroom');
    if (div2.style.display == 'block') {
        div2.style.display = 'none';
        div1.style.display = 'block';

    } else {
        div2.style.display = 'block';
        div1.style.display = 'none';
    }
});
