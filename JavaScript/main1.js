// TypeScript source code
/// <reference path="jquery/jquery.d.ts" />
function yHandler() {
    var popUp = document.getElementById("popArt");
    var contentHeight = popUp.offsetHeight;
    var yOffset = window.pageYOffset;
    var y = yOffset + window.innerHeight;
    if (y >= contentHeight + 100) {
        popUp.style.visibility = "visible";
    }
    if (y <= contentHeight + 100) {
        popUp.style.visibility = "hidden";
    }
}
function closer() {
    $(function () {
        $("#closeX").click(function () {
            $("#closeX").hide();
            $("#popArt").hide();
        });
    });
}
(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id))
        return;
    js = d.createElement(s);
    js.id = id;
    js.src = "//connect.facebook.net/en_GB/sdk.js#xfbml=1&version=v2.7";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));
