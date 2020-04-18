/*efecto para imagenes*/
$(document).ready(function () {

    $('div').on('click', 'img.imgGallery', function () {

        $(this).animate({
            opacity: "toggle"
        }, 100, function () {
            // Animation complete.
        });

        var srcSeledted = $(this).attr("src");
        $('.imgSelected').attr("src", srcSeledted);
    });

   
});