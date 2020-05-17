function initMap() {
    //se verifica si el navegador puede obtener la ubicacion
    if (navigator.geolocation) {
        //llama al metodo coordenas y le pasa la posicion
        navigator.geolocation.getCurrentPosition(coordenadas);
    } else {
        alert('Este navegador es algo antiguo, actualiza para usar el API de localización');
    }
}//initMap

function coordenadas(position) {
    //nos da las herramientas necesarias para que visualicemos en el navegador 
    var directionsService = new google.maps.DirectionsService;
    //busca en las bases de datos de Google Maps las rutas
    var directionsDisplay = new google.maps.DirectionsRenderer;
    //con base a la posicion obtiene la latitud
    var lat = position.coords.latitude;
    //con base a la posicion obtiene la latitud
    var lon = position.coords.longitude;
    //añade los puntos de la ruta  
    var waypts = [{ location: { lat: lat, lng: lon }, stopover: true }, { location: { lat: 10.404615, lng: -85.802453 }, stopover: true }];
    //construye el mapa con la api acupa (el lugar de partida y el lugar donde se va mostrar)
    var map = new google.maps.Map(document.getElementById('map'), { zoom: 15, center: { lat: waypts[0].location.lat, lng: waypts[0].location.lng } });
    //añade el mapa
    directionsDisplay.setMap(map);
    //traza la ruta en el mapa utilizando el vector waypts
    directionsService.route({
        origin: { lat: waypts[0].location.lat, lng: waypts[0].location.lng },//db waypoint start
        destination: { lat: waypts[0].location.lat, lng: waypts[0].location.lng },//db waypoint end
        waypoints: waypts,
        travelMode: google.maps.TravelMode.WALKING
    }, function (response, status) {
        if (status === google.maps.DirectionsStatus.OK) {
            directionsDisplay.setDirections(response);
        } else {
            window.alert('Ha fallat la comunicació amb el mapa a causa de: ' + status);
        }
    });
}//coordednadas