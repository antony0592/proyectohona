//Document ready
    $(document).ready(function () {
        loadDataPublicity();       
    });

function AddPublicity() {

    $("#updatepublicity").hide();
    $("#addpublicity").show();
    $("#divactualimageP").hide();
    $("#contentPublicity").val("");
    $("#filePublicity").val("");
    $("#listP").hide();

    $(".modal").on("click", "button#addpublicity", function () {

        var formData = new FormData();
        var selectFile = ($("#filePublicity"))[0].files[0];
        var content = $("#contentPublicity").val();

        formData.append("files", selectFile);
        formData.append("content", content);

        if (content.trim() == "") {
            alert("Por favor ingrese un texto");
        } else if (selectFile == null) {
            alert("Por favor ingrese una imagen");
        }

        if ($("#contentPublicity").val().match(/^(ht|f)tps?:\/\/\w+([\.\-\w]+)?\.([a-z]{2,6})?([\.\-\w\/_]+)$/i)) {

            $.ajax({
                url: "/AdministratorPublicity/AddUpdatePublicity",
                type: "POST",
                data: formData,
                contentType: false,
                processData: false,
                // async: false,
                success: function (result) {

                    if (result > 0) {
                        $('output').find('span').remove();
                        $("#filePublicity").val("");
                        $("#UpdateModalPublicity .close").click();
                        loadDataPublicity();
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

function deletecontentpagePublicity(id) {
        $(".modal").on("click", "button#btndeletepublicity", function () {
            $.ajax({
                url: "/AdministratorPublicity/DeletePublicity/" + id,
                type: "POST",
                contentType: "application/json;charset=UTF-8",
                dataType: "json",
                success: function (result) {
                    loadDataPublicity();
                    $("#DeleteModalPublicity .close").click();
                },
                error: function (errormessage) {
                    alert("Error, por favor intentelo de nuevo");
                }
            });
        });
    }

function updatecontentpagePublicity(id) {

    $("#filePublicity").val("");
    $("#divactualimageP").show();
    $("#updatepublicity").show();
    $("#addpublicity").hide();
    $('output').find('span').remove();  
    

    //get seleted publicity by id
    $.ajax({
        url: "/AdministratorPublicity/GetPublicityById/" + id,
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            $("#imgPublicity").attr("src", result.urlimage);
            $("#contentPublicity").val(result.content);
            //$("#filePublicity").val(result.urlimage);

        },

        error: function (errorMessage) {
            alert("Error al cargar los datos");
        }
    });

    $(".modal").on("click", "button#updatepublicity", function () {

        var formData = new FormData();
        var selectFile = ($("#filePublicity"))[0].files[0];
        var content = $("#contentPublicity").val();
        
        formData.append("files", selectFile);
        formData.append("content", content);
        formData.append("idPublicity", id);

        if (content.trim() == "") {
            alert("Por favor ingrese un texto");
        }
        //else if (selectFile == null) {
        //    alert("Por favor ingrese una imagen");
        //}

        if ($("#contentPublicity").val().match(/^(ht|f)tps?:\/\/\w+([\.\-\w]+)?\.([a-z]{2,6})?([\.\-\w\/_]+)$/i)) {

            $.ajax({
                url: "/AdministratorPublicity/AddUpdatePublicity",
                type: "POST",
                data: formData,
                contentType: false,
                processData: false,
               // async: false,
                success: function (result) {

                    if (result>0) {
                        $('output').find('span').remove();
                        $("#filePublicity").val("");
                        $("#UpdateModalPublicity .close").click();
                        loadDataPublicity();
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

function loadDataPublicity() {

        $.ajax({
            url: "/AdministratorPublicity/ListAll",
            type: "GET",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                dataSet = new Array();
                var html = '';
                $.each(result, function (key, item) {

                    data = [
                        item.id,
                        '<a target="_blank" href="' + item.content + '">' + item.content +' </a>',
                        '<td class="text-center"><img class="img-responsive rounded mx-25 d-block" src="' + item.urlimage +'" alt="" width="70" height="50"></td>',
                        '<td class= "text-center">' +
                        '  <div data-toggle="modal" data-target="#UpdateModalPublicity" class="btn-group btn-group-xs"><a href="#" onclick="return updatecontentpagePublicity(' + item.id + ')" title="Modificar" class="btn btn-default"><i class="fa fa-pen-square"></i> </a></div>' +
                        '  <div data-toggle="modal" data-target="#DeleteModalPublicity" class="btn-group btn-group-xs"><a href="#" onclick="return deletecontentpagePublicity(' + item.id + ')" title="Eliminar" class="btn btn -default"><i class="fa fa-eraser"></i> </a></div>' +
                        '</td >'
                    ];

                    dataSet.push(data);
                });
                $('#tbpublicity').DataTable({
                    "searching": true,
                    data: dataSet,
                    "bDestroy": true,
                    responsive: true,
                    scrollX: true,
                    lengthMenu: [[5, 10, 20, -1], [5, 10, 20, "All"]]

                });

            },
            error: function (errorMessage) {
                alert(errorMessage.responseText);
            }
        })
    }

function handleFileSelectPublicity(evt) {
    $('output').find('span').remove();
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

                $("#listP").show();
                document.getElementById('listP').insertBefore(span, null);
            };
        })(f);
        // Read in the image file as a data URL.
        reader.readAsDataURL(f);
    }
    
}

document.getElementById('filePublicity').addEventListener('change', handleFileSelectPublicity, false);