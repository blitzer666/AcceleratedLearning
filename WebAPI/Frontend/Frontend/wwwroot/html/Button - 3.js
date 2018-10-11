let bulbOff = '<img src="pics/offlight">';
let bulbOn = '<img src="pics/onlight">';

let knapp5 = document.getElementById("knapp5");

let number = [1, 2, 3, 4, 5];

let sometext = document.getElementById("sometext");

index = 0;
lastIndex = null;


knapp5.addEventListener("click", () => {

    let stringOff = "goodPlaceForBulb" + lastIndex

    if (lastIndex != null) {
        document.getElementById(stringOff).innerHTML = bulbOff;
    }

    lastIndex = index;

    let stringOn = "goodPlaceForBulb" + index

    document.getElementById(stringOn).innerHTML = bulbOn;

    sometext.innerHTML = "Current bulb: " + number[index];
    index = (index + 1) % number.length

});