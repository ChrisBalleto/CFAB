weather();
function weather() {
    $.ajax({
        url: 'http://api.openweathermap.org/data/2.5/forecast?q=milwaukee,us&appid=da80198220685bc49e1e8df5738ba178',
        type: 'GET',
        dataType: 'jsonp',
        success: function (data) {
            var wrapper = $("#WeatherWrapper");
            wrapper.empty();
            wrapper.append(printData(data));
        },
        error: function () {
            console.log('Failed!');
        }
    });
}

function printData(data) {
    for (var i = 0; i < 40; i+=8) {
        $('#showResults').append('<tr><td></td><td>' + data.list[i].dt_txt.split(/[" "]/)[0].replace("2017-", "") + '</td>'
        + '<td>' + data.city.name + '</td>'
        + '<td>' + Math.round(data.list[i].main.temp - 242) + "\xB0F" + '</td>'
        + '<td>' + data.list[i].weather[0].description + ' </td>'
        + '<td>' + data.list[i].wind.speed + " mph" + ' </td></tr>')};
        console.log(data);
}