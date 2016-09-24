
$(document).ready (function() {
    $.getJSON('http://en.wikipedia.org/w/api.php?action=parse&page=cake&prop=text&format=json&callback=?', function(json) { 
        $('#wikiInfo').html(json.parse.text['*']); 
        $('#wikiInfo').find("a:not(.references a)").attr("href", function(){ return "http://www.wikipedia.org" + $(this).attr("href");}); 

    });
});