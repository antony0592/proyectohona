//Document ready
$(document).ready(function () {
    $("#description").keyup(function (e) {

        var control = $("#description").val();        
        if (control.length == 0 || control.trim()=="") {
            $("#messageModifyHome").text("Debe agregar una descripción");
        }
        else
        {
            $("#messageModifyHome").text("");
        }        
    })

    $("#descriptionArea").keyup(function (e) {
        var control = $("#descriptionArea").val(); 
        if (control.length == 0 || control.trim() == "") {
            $("#messageModifyRooms").text("Debe agregar una descripción");
        }
        else {
            $("#messageModifyRooms").text("");
        }
    })

    $("#amount").keyup(function (e) {
        var control = $("#amount").val();
        if (control.length == 0 || control.trim() == "") {
            $("#messageModifyRooms").text("Debe agregar una descripción");
        }
        else {
            $("#messageModifyRooms").text("");
        }
    })

    $("#descriptionArea").keyup(function (e) {
        var control = $("#descriptionArea").val();
        if (control.length == 0 || control.trim() == "") {
            $("#messageModifyRooms").text("Debe agregar una descripción");
        }
        else {
            $("#messageModifyRooms").text("");
        }
    })

    $("#descriptionB").click(function (e) {

        if ($("#amount").val() == 0 || $("#amount").val().trim() == "") {
            e.preventDefault();
            $("#messageModifyRooms2").text("Coloque un precio");
        }

        if ($("#descriptionArea").val() == 0 || $("#descriptionArea").val().trim() == "") {
            e.preventDefault();
            $("#messageModifyRooms2").text("Coloque una descripción");
        }

        if ($("#description").val() == -1) {
            e.preventDefault();
            $("#messageModifyRooms2").text("Seleccione un tipo de habitación");
        }
    })



    

    
});
