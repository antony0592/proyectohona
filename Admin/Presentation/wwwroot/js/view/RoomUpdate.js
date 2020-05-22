////Document ready
//$(function () {
//    $("#descriptionB").click(function () {
//        alert("Hola");
//    });
//});

//$(document).ready(function () {
//    $("#descriptionB").on("click", function (e) {
//        e.preventDefault();
//        $.ajax({
//            url: "/AdministratorManageRooms/GetRoom/",
//            type: "POST",
//            data: { 'description': $('#description').val() },
//            contentType: "application/json;charset=utf-8",
//            dataType: "json",
//            success: function (result) {
//                if (result) {
//                    $("#descriptionType").html(" " + result.description + " ");
//                    //$("#quantity").html(" " + result.amount + " ");
//                    //$("#image").html(" " + result.url + " ");

//                    $("#alert").html("Hemos encontrado esta habitación para ti:");
//                },

//                error: function (errorMessage) {
//                    alert(errorMessage.responseText);
//                }
//            });
//    });
//});
