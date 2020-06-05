//Document ready
    $(document).ready(function () {
        loadData();
    });


    function Delete(id) {
        $(".modal").on("click", "button#btndeletepublicity", function () {
            $.ajax({
                url: "/AdministratorPublicity/Delete/" + id,
                type: "POST",
                contentType: "application/json;charset=UTF-8",
                dataType: "json",
                success: function (result) {
                    loadData();
                    $('#DeleteModalPublicity').modal('hide');

                },
                error: function (errormessage) {
                    alert("Error, por favor intentelo de nuevo");
                }
            });
        });
    }



    function GetById(studentId) {
        $.ajax({
            url: "/Student/GetByIdSp/" + studentId,
            type: "GET",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {

                $('#StudentId').val(result.StudentId);
                $('#Name').val(result.Name);
                $('#Age').val(result.Age);

                $("select#NationalitiesDropdown").val(result.NationalityId);

                $("#MajorsDropdown").val(result.MajorId);

                $('#myModal').modal('show');
                $('#btnUpdate').show();
                $('#btnAdd').hide();
            },

            error: function (errorMessage) {
                alert(errorMessage.responseText);
            }
        });
    }



    function Update(student) {

        var inWhite = isNull(student);
        if (inWhite.length == 0) { }


        var nationality = {
            NationalityId: $("#NationalitiesDropdown option:selected").val()
        };
        var major = {
            MajorId: $("#MajorsDropdown option:selected").val()
        }
        var student = {
            StudentId: $('#StudentId').val(),
            Name: $('#Name').val(),
            Age: $('#Age').val(),
            StudentNationality: nationality,
            StudentMajor: major
        };

        var inWhite = isNull(student);
        var errorMessage = "";

        if (inWhite.length == 0) {

            $.ajax({
                url: "/Student/UpdateSp",
                data: JSON.stringify(student),
                type: "POST",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (result) {
                    loadData();
                    $('#myModal').modal('hide');
                },
                error: function (errorMessage) {
                    console.log(errorMessage.responseText);
                    alert(errorMessage.responseText);
                }
            })
        } else {
            for (i = 0; i < inWhite.length; i++) {
                errorMessage += inWhite[i] + ",";
            }
            $('#error').text("Empty spaces:" + errorMessage);
            errorMessage = "";
        }

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
                        '  <div data-toggle="modal" data-target="#UpdateModalPublicity" class="btn-group btn-group-xs"><a href="#" onclick="return updatecontentpage(' + item.id + ')" title="Modificar" class="btn btn-default"><i class="fa fa-pen-square"></i> </a></div>' +
                        '  <div data-toggle="modal" data-target="#DeleteModalPublicity" class="btn-group btn-group-xs"><a href="#" onclick="return deletecontentpage(' + item.id + ')" title="Eliminar" class="btn btn -default"><i class="fa fa-eraser"></i> </a></div>' +
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
                    lengthMenu: [[10, 25, 50, -1], [10, 25, 50, "All"]]

                });

            },
            error: function (errorMessage) {
                alert(errorMessage.responseText);
            }
        })
    }

