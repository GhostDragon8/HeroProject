(function (){
    var map = new GMaps
    ({
        div:'#map',
        lat: -12.043333,
        lng: -77.0283333 
    });
	/*
    var map1 = new GMaps
    ({
        div:'#map',
        lat: -12.043333,
        lng: -77.0283333 
    });
    var map2 = new GMaps
    ({
        div:'#map',
        lat: -12.043333,
        lng: -77.0283333,
        zoom: 10
    });
	

    GMaps.geocode
    ({
        address:'Galloway',
        callback: function (results, status)
        {
            if (status== 'OK')
                var latlng = results[0].geometry.location;
            map.setCenter(latlng.lat(), latlng.lng());
            map.addMarker
            ({
                lat: latlng.lat(), 
                lng: latlng.lng()
            });
        }
    })
	*/
});