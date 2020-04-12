function initMap() {

    var myLatLng = new google.maps.LatLng(9.8239293, -83.5573497);
    var mapOptions = {
        center: myLatLng,
        zoom: 12
    };
    var map = new google.maps.Map(document.getElementById('map'), mapOptions);

    var marker = new google.maps.Marker({
        position: myLatLng,
        title: 'hola',
        map: map
    })
}