window.onload = function () {
    // creamos los eventos para cada elemento con la clase "boton"
    let elementsConsult = document.getElementsByClassName("consult");
    let elementsDelete = document.getElementsByClassName("delete");
    if (elementsConsult != null) {
        for (let i = 0; i < elementsConsult.length; i++) {
            // cada vez que se haga clic sobre cualquier de los elementos,
            // ejecutamos la función obtenerValores()
            elementsConsult[i].addEventListener("click", obtainValues);
        }
    }
    if (elementsDelete != null) {
        for (let i = 0; i < elementsDelete.length; i++) {
            // cada vez que se haga clic sobre cualquier de los elementos,
            // ejecutamos la función obtenerValores()
            elementsDelete[i].addEventListener("click", deleteValues);
        }
    }
}
// funcion que se ejecuta cada vez que se hace clic
function obtainValues(e) {
    var creationdate = "";
    var id = "";
    var name = "";
    var lastname = "";
    var email = "";
    var number = "";
    var arrivaldate = "";
    var departuredate = "";
    var description = "";

    // vamos al elemento padre (<tr>) y buscamos todos los elementos < td >
    // que contenga el elemento padre
    var elementosTD = e.srcElement.parentElement.getElementsByTagName("td");
    // obtenemos cada uno de los valores y los ponemos en la variable "valores"
    creationdate = elementosTD[0].innerHTML;
    id = elementosTD[1].innerHTML;
    name = elementosTD[2].innerHTML;
    lastname = elementosTD[3].innerHTML;
    email = elementosTD[4].innerHTML;
    number = elementosTD[5].innerHTML;
    arrivaldate = elementosTD[6].innerHTML;
    departuredate = elementosTD[7].innerHTML;
    description = elementosTD[8].innerHTML;
    document.getElementById("creationdate").innerHTML += creationdate;
    document.getElementById("id").innerHTML += id;
    document.getElementById("name").innerHTML += name;
    document.getElementById("lastname").innerHTML += lastname;
    document.getElementById("email").innerHTML += email;
    document.getElementById("number").innerHTML += number;
    document.getElementById("arrivaldate").innerHTML += arrivaldate;
    document.getElementById("departuredate").innerHTML += departuredate;
    document.getElementById("description").innerHTML += description;
}

function deleteValues(e) {
    var id = "";

    // vamos al elemento padre (<tr>) y buscamos todos los elementos < td >
    // que contenga el elemento padre
    var elementosTD = e.srcElement.parentElement.getElementsByTagName("td");
    // obtenemos cada uno de los valores y los ponemos en la variable "valores"
    id = elementosTD[1].innerHTML;

    $.ajax({
        url: "/AdministratorReservationList/DeleteReservationList",
        data: { 'id':id },
        type: 'GET',

    });
}

function cambiaVisibilidad() {
    var div1 = document.getElementById('principal');
    var div2 = document.getElementById('getreservation');
    if (div2.style.display == 'block') {
        div2.style.display = 'none';
        div1.style.display = 'block';

    } else {
        div2.style.display = 'block';
        div1.style.display = 'none';
    }
}

$(document).on("click", ".delete", function () {
    event.preventDefault();
    if (window.confirm("¿Desea eliminar?")) {
        $(this).closest('#tbl tr').remove();
    }
});
