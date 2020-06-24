$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#wrapper").toggleClass("toggled");
});



/*Efecto Titulo*/
$(function () {
    var $jittery = $('.titulo'),
        aText = $jittery.text().split(''),
        letters = '';

    for (var i = 0; i < aText.length; i++) {
        letters += '<span>' + aText[i] + '</span>';
    }

    $jittery.empty().append(letters);

    $.each($('span', $jittery), function (i) {
        $(this).css('animation-delay', '-' + i + '70ms');
    });
});


$(document).ready(function () {
    $('#facilitiesTable').DataTable({"lengthMenu": [[5, 10, 20, -1], [5, 10, 20, "All"]]});
    $('#reservationTable').DataTable({"lengthMenu": [[5, 10, 20, -1], [5, 10, 20, "All"]]});
});