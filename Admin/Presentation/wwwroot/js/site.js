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
    $('#stateTable').DataTable({ "lengthMenu": [[5, 10, 20, -1], [5, 10, 20, "All"]] });
    $('.tableTypeRoom').DataTable({ "lengthMenu": [[5, 10, 20, -1], [5, 10, 20, "All"]] });
});

$(document).ready(function () {

    var path = window.location.pathname;
    var abc = path.split("/");
    var controller = abc[1];
    var id = "#" + controller;
    if (id == "#") { id = "#Home" }
    $(id).attr("style", "color:#2dca98");
    $(id).css("font-size", "125%");
    $(id).css("textext-align", "right");
    $(id).animate({ left: '20px' }, "slowx");

});

