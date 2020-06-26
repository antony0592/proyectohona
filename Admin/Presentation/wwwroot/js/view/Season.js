window.onload = function () {

    // creamos los eventos para cada elemento con la clase "boton"
    let elementsDeleteSeason = document.getElementsByClassName("deleteSeason");

    if (elementsDeleteSeason != null) {
        for (let i = 0; i < elementsDeleteSeason.length; i++) {
            // cada vez que se haga clic sobre cualquier de los elementos,
            // ejecutamos la función obtenerValores()
            elementsDeleteSeason[i].addEventListener("click", deleteValuesSeason);
        }
    }
}

function deleteValuesSeason(e) {
    var id = "";
    // vamos al elemento padre (<tr>) y buscamos todos los elementos < td >
    // que contenga el elemento padre
    var elementosTD = e.srcElement.parentElement.getElementsByTagName("td");
    // obtenemos cada uno de los valores y los ponemos en la variable "valores"
    id = elementosTD[0].innerHTML;

    $.ajax({
        url: "/AdministratorSeason/DeleteSeason",
        data: { 'id': id },
        type: 'GET',

    });

}

$(document).on("click", ".deleteSeason", function () {
    event.preventDefault();
    if (window.confirm("¿Desea eliminar?")) {
        $(this).closest('#tableSeason tr').remove();
    }

    // creamos los eventos para cada elemento con la clase "boton"
    let elementsDeleteSeason = document.getElementsByClassName("deleteSeason");

    if (elementsDeleteSeason != null) {
        for (let i = 0; i < elementsDeleteSeason.length; i++) {
            // cada vez que se haga clic sobre cualquier de los elementos,
            // ejecutamos la función obtenerValores()
            elementsDeleteSeason[i].addEventListener("click", deleteValuesSeason);
        }
    }

});
$(document).ready(function () {
    $('#tableSeason').DataTable({ "lengthMenu": [[5, 10, 20, -1], [5, 10, 20, "All"]] });
});

