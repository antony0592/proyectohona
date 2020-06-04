
function SearchRoomAvailability() {

    $.ajax({
        url: "/AdministratorAvailability/SearchRoomAvailability",
        type: "GET",
        data: { 'date1': $('#arrivaldateA').val(), 'date2': $('#departuredateA').val(), 'typeRoom': $('#typeroomcbA').val() },
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            dataSet = new Array();
            $('#reservationtablecontainer').show();

            $.each(result, function (key, item) {
                data = [
                    item.number,
                    item.typeroom,
                    item.amount
                ];
                dataSet.push(data);
            });

            $('#reservationtable').DataTable({
                "lengthMenu": [5, 10, 15],
                "searching": true,
                data: dataSet,
                "bDestroy": true
            });
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}

$(document).ready(function () {


    $('#reservationtablecontainer').hide();

    // Function which returns a minimum of two digits in case the value is less than 10
    const getTwoDigits = (value) => value < 10 ? `0${value}` : value;

    const formatDate = (date) => {
        const day = getTwoDigits(date.getDate());
        const month = getTwoDigits(date.getMonth() + 1); // add 1 since getMonth returns 0-11 for the months
        const year = date.getFullYear();

        return `${year}-${month}-${day}`;
    }

    const formatDate2 = (date) => {
        const day = getTwoDigits(date.getDate() + 2);
        const month = getTwoDigits(date.getMonth() + 1); // add 1 since getMonth returns 0-11 for the months
        const year = date.getFullYear();

        return `${year}-${month}-${day}`;
    }

    const formatDate3 = (date) => {
        const day = getTwoDigits(date.getDate() + 1);
        const month = getTwoDigits(date.getMonth() + 1); // add 1 since getMonth returns 0-11 for the months
        const year = date.getFullYear();

        return `${year}-${month}-${day}`;
    }

    const formatTime = (date) => {
        const hours = getTwoDigits(date.getHours());
        const mins = getTwoDigits(date.getMinutes());

        return `${hours}:${mins}`;
    }

    const date = new Date();
    /*define valores por defecto y minimos en el selector de fecha*/
    document.getElementById('arrivaldateA').value = formatDate(date);
    document.getElementById('arrivaldateA').min = formatDate(date);
    /*define valores por defecto y minimos en el selector de fecha*/
    document.getElementById('departuredateA').value = formatDate2(date);
    document.getElementById('departuredateA').min = formatDate3(date);

    /*Cambia automáticamente el límite del siguiente selector de fecha*/
    function datechange() {
        document.getElementById('departuredateA').min = document.getElementById('arrivaldateA').value;
    }
});

$(document).ready(function () {
    $('#reservationtable').DataTable();
});