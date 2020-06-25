$(document).ready(function () {
    $("#file").val() == "";

    $("#description").change(function () {
        $("#descriptionArea").html("");

        $.ajax({
            url: "/AdministratorManageRooms/GetManageRooms",
            type: "GET",
            data: { 'description': $('#description').val() },
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                console.log(result);
                if (result) {
                    $("#amount").val(result.amount);
                    $("#descriptionArea").val(result.descriptiontyperoom);
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
    $("#principal").hide();
    $("#manageroom").show();
});

$(document).on("click", "#cancelManageRoom", function () {

    $("#principal").show();
    $("#manageroom").hide();
});

