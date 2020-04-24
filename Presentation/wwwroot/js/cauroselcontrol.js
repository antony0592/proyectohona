/*caurosel control img*/
$(document).ready(function () {
    publicitycarousel();
});

function publicitycarousel() {

    $.ajax({
        url: "/Home/GetPublicity",
        type: "GET",
        dataType: "json",
        contentType: "application/json;charset=utf-8",
        success: function (result) {

            for (var i in result) {
                $(".carousel-inner").append(
                    "<div class='carousel-item' data-interval='10000'>" +
                    "<img src='" + result[i].urlimage+"' class=' publicityimg d-block w-100'>"
                    + " </div >");
                console.log(result[i].urlimage);
            }
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });

}