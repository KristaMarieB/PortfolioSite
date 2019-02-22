
var $ = function (id) {
    return document.getElementById(id);
};

window.onload = function () {
    quoteSource = [
        {
            quote: "Just because something doesn’t do what you planned it to do doesn’t mean it’s useless.",
            name: "Thomas Edison"
        },
        {
            quote: "The life in front of you is way more important than the life behind you.",
            name: "unknown"
        },
        {
            quote: "We all have different reasons for forgetting to breathe.",
            name: "Andrea Gibson"
        },
        {
            quote: "Let's get lost in a world of books, coffee, and rainy days.",
            name: "unknown"
        },
        {
            quote: "You still have a lot of time to make yourself be what you want",
            name: "unknown"
        },
        {
            quote: "Be fearless in the pursuit of what sets your soul on fire",
            name: "unknown"
        },
        {
            quote: "And once the storm is over, you won’t remember how you made it through, how you managed to survive. You won’t even be sure, whether the storm is really over. But one thing is certain. When you come out of the storm, you won’t be the same person who walked in. That’s what this storm’s all about.",
            name: "Haruki Murakami"
        },
        {
            quote: "When you’re at the end of your rope, tie a knot and hold on.",
            name: "Theodore Roosevelt"
        },
        {
            quote: "Let us choose for ourselves our path in life, and let us try to strew that path with flowers.",
            name: "Emilie du Chatelet"
        },
        {
            quote: "If you know you are on the right track, if you have this inner knowledge, then nobody can turn you off… no matter what they say.",
            name: "Barbara McClintock"
        },
        {
            quote: "The more clearly we can focus our attention on the wonders and realities of the universe about us, the less taste we shall have for destruction.",
            name: "Rachel Carson"
        },
        {
            quote: "Life need not be easy, provided only that it is not empty.",
            name: "Lise Meitner"
        },
        {
            quote: "Don’t let anyone rob you of your imagination, your creativity, or your curiosity. It’s your place in the world; it’s your life. Go on and do all you can with it, and make it the life you want to live.",
            name: "Mae Jemison"
        }

    ];

    getQuote();
}

function getQuote() {
    
    var randomNumber = Math.floor(Math.random() * quoteSource.length);

    var newQuoteText = quoteSource[randomNumber].quote;
    var newQuoteGenius = quoteSource[randomNumber].name;

    quoteContainer.append(newQuoteText);
    quoteGenius.append(newQuoteGenius);
}