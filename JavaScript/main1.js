// TypeScript source code
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
//# sourceMappingURL=main1.js.map