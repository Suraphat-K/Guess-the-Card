async function guessCard() {
    let suit = document.getElementById("suit").value;
    let value = document.getElementById("value").value;

    let res = await fetch("/api/card/guess", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ suit: suit, value: value })
    });

    let text = await res.text();
    document.getElementById("result").innerText = text;
}