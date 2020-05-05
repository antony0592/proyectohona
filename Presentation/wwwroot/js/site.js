$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#wrapper").toggleClass("toggled");
});

$(document).ready(function () {
    $('#summernote').summernote();
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

    $('form').on('click', '#loginpaypal', function (e) {
        e.preventDefault();
        $("#formpaypal").hide();

        $(this).closest(".modal-body").append("<img id='loader' src='/images/loader.gif' />");

        $(this).animate({
            opacity: 0.5
        }, 2000, function () {
                $(this).closest(".modal-body").find("img#loader").hide();
                $("#conpay").show();
        });

       
        
    });
});