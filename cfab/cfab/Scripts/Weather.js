$(document).ready(function () {
    $("button").click(function () {
        $.get(
        "http://api.openweathermap.org/data/2.5/forecast?q=milwaukee,us&appid=da80198220685bc49e1e8df5738ba178",
        function (response) {
            $("#reply").text(response.name);
        });
    });
});
