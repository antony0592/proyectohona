//Document ready
$(document).ready(function () {
    loadData();
});

function AddFacility() {

    $("#updatefacility").hide();
    $("#addfacility").show();
    $("#divactualimage").hide();
    $("#contentFacility").val("");
    $("#fileFacility").val("");
    $("#list").hide();

    $(".modal").on("click", "button#addfacility", function () {

        var formData = new FormData();
        var selectFile = ($("#fileFacility"))[0].files[0];
        var content = $("#contentFacility").val();

        formData.append("files", selectFile);
        formData.append("content", content);

        if (content.trim() == "") {
            alert("Por favor ingrese un texto");
        } else if (selectFile == null) {
            alert("Por favor ingrese una imagen");
        }

        if ($("#contentFacility").val()!=null) {

            $.ajax({
                url: "/AdministratorFacility/AddUpdateFacility",
                type: "POST",
                data: formData,
                contentType: false,
                processData: false,
                // async: false,
                success: function (result) {

                    if (result > 0) {
                        $('output').find('span').remove();
                        $("#fileFacility").val("");
                        $("#UpdateModalFacility .close").click();
                        loadData();
                    } else {
                        alert("Error.Por favor intente de nuevo");
                    }
                },
                error: function (errorMessage) {
                    alert("Error.Por favor intente de nuevo");
                }
            });
        }
        else {
            alert("NO deje descripción en blanco");
        }
    });

}

function deletecontentpage(id) {
    $(".modal").on("click", "button#btndeletefacility", function () {
        $.ajax({
            url: "/AdministratorFacility/DeleteFacility/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                loadData();
                $("#DeleteModalFacility .close").click();
            },
            error: function (errormessage) {
                alert("Error, por favor intentelo de nuevo");
            }
        });
    });
}

function GetById(id) {

}

function updatecontentpage(id) {

    $("#updatefacility").show();
    $("#addfacility").hide();

    //get seleted facility by id
    $.ajax({
        url: "/AdministratorFacility/GetFacilityById/" + id,
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            $("#imgFacility").attr("src", result.urlimage);
            $("#contentFacility").val(result.content);
            //$("#filePublicity").val(result.urlimage);

        },

        error: function (errorMessage) {
            alert("Error al cargar los datos");
        }
    });





    $(".modal").on("click", "button#updatefacility", function () {

        var formData = new FormData();
        var selectFile = ($("#fileFacility"))[0].files[0];
        var content = $("#contentFacility").val();

        formData.append("files", selectFile);
        formData.append("content", content);
        formData.append("idFacility", id);

        if (content.trim() == "") {
            alert("Por favor ingrese un texto");
        } else if (selectFile == null) {
            alert("Por favor ingrese una imagen");
        }

        if ($("#contentFacility").val() !=null) {

            $.ajax({
                url: "/AdministratorFacility/AddUpdateFacility",
                type: "POST",
                data: formData,
                contentType: false,
                processData: false,
                // async: false,
                success: function (result) {

                    if (result > 0) {
                        $('output').find('span').remove();
                        $("#fileFacility").val("");
                        $("#UpdateModalFacility .close").click();
                        loadData();
                    } else {
                        alert("Error.Por favor intente de nuevo");
                    }
                },
                error: function (errorMessage) {
                    alert("Error.Por favor intente de nuevo");
                }
            });
        }
        else {
            alert("Dirección web no válida");
        }
    });
}

function isNull(object) {

    var inWhite = [];
    var cont = 0;
    for (const property in object) {

        try {
            if (object[property].trim() == "") {
                inWhite[cont] = property;
                cont++;
            }
        } catch (error) {
        }
    }
    return inWhite;
}

function loadData() {

    $.ajax({
        url: "/AdministratorFacility/ListAll",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            dataSet = new Array();
            var html = '';
            $.each(result, function (key, item) {

                data = [
                    item.id,
                    '<a target="_blank" href="' + item.content + '">' + item.content + ' </a>',
                    '<td class="text-center"><img class="img-responsive rounded mx-25 d-block" src="' + item.urlimage + '" alt="" width="70" height="50"></td>',
                    '<td class= "text-center">' +
                    '  <div data-toggle="modal" data-target="#UpdateModalFacility" class="btn-group btn-group-xs"><a href="#" onclick="return updatecontentpage(' + item.id + ')" title="Modificar" class="btn btn-default"><i class="fa fa-pen-square"></i> </a></div>' +
                    '  <div data-toggle="modal" data-target="#DeleteModalFacility" class="btn-group btn-group-xs"><a href="#" onclick="return deletecontentpage(' + item.id + ')" title="Eliminar" class="btn btn -default"><i class="fa fa-eraser"></i> </a></div>' +
                    '</td >'
                ];

                dataSet.push(data);
            });
            $('#tbfacility').DataTable({
                "searching": true,
                data: dataSet,
                "bDestroy": true,
                responsive: true,
                scrollX: true,
                lengthMenu: [[10, 25, 50, -1], [10, 25, 50, "All"]]

            });

        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    })
}

function handleFileSelect(evt) {
    var files = evt.target.files; // FileList object

    // Loop through the FileList and render image files as thumbnails.
    for (var i = 0, f; f = files[i]; i++) {

        // Only process image files.
        if (!f.type.match('image.*')) {
            continue;
        }
        var reader = new FileReader();
        // Closure to capture the file information.
        reader.onload = (function (theFile) {
            return function (e) {
                // Render thumbnail.
                var span = document.createElement('span');
                span.innerHTML = ['<img class="thumb" style="height:100px" src="', e.target.result,
                    '" title="', escape(theFile.name), '"/>'
                ].join('');

                $("#list").show();
                document.getElementById('list').insertBefore(span, null);
            };
        })(f);
        // Read in the image file as a data URL.
        reader.readAsDataURL(f);
    }

}

/*document.getElementById('fileFacility').addEventListener('change', handleFileSelect, false);
