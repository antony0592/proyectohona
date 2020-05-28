
function SearchRoomAvailability() {

    $.ajax({
        url: "/AdministratorAvailability/SearchRoomAvailability",
        type: "GET",
        data: { 'date1': $('#arrivaldateA').val(), 'date2': $('#departuredateA').val(), 'typeRoom': $('#typeroomcbA').val() },
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            console.log(result);
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}