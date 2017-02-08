getWeather: function() {
    $.ajax({
        url: 'http://api.openweathermap.org/data/2.5/forecast?q=milwaukee,us&appid=da80198220685bc49e1e8df5738ba178',
        type: 'GET',
        dataType: 'jsonp',
        success: function (data) {
            var wrapper = $("#WeatherWrapper");
            wrapper.empty();
            wrapper.append(mainWeather.createWeatherWidg(data));
        },
        error: function() {
            alert('Failed!');
        }
 
    });
}
 
//Prints result from the weatherapi, receiving as param an object
createWeatherWidg: function(data) {
    return "<div class='pressure'> <p>Temperature: " + (data.main.temp - 273.15).toFixed(2) + " C</p></div>"+
            "<div class='description'> <p>Title: " + data.weather[0].main + "</p></div>" +
            "<div class='description'> <p>Description: " + data.weather[0].description + "</p></div>" +
            "<div class='wind'> <p>Wind Speed: " + data.wind.speed + "</p></div>" +
            "<div class='humidity'> <p>Humidity: " + data.main.humidity + "%</p></div>" +
            "<div class='pressure'> <p>Pressure: " + data.main.pressure + " hpa</p></div>";
}