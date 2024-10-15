// Get current page address (URL) using window.location.
function doSomething() {
    var path = window.location.pathname;
    var page = path.split("/").pop();
    alert(`You are currently visting the ${page} page... `);
    changeArticleText();
    showCats();
}

function changeArticleText() {
    // Wildcard query selector.
    // ...
    const articles = document.querySelector('[id^="article"]');
    if (articles.id == "articleFirst") {
        articles.textContent = "You clicked the button on the index.html page!";
    } else if (articles.id == "articleSecond") {
        articles.textContent = "You clicked the button on the second.html page!";
    }
}

function showCats() {
    // Get cat DIV
    var cats = document.querySelectorAll(".cat-loader");
    var style;

    cats.forEach(img => {
        img.style.display = "block";
    });
}
