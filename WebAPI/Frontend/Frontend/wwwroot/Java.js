
// var1()

// function var1() {
//      Skriv ut "Jag heter XXXX" 
//     console.log("Jag heter Peter")
// }

// let a = 35
// console.log(a)

// function var2() {
//     /* 
//     Skapa variabel och sätt det till 35. 
//     Meddela värdet av siffran (med hjäp av "console.log")
//     */
// }

// let x = 12
// let y = 6
// let z = x+y
// console.log(z)

// function var3() {

    
//      Skapa en variabel "x" med värdet 12
//      Skapa en variabel "y" med värdet 6
//      Skapa en variabel "z" som summerar talen
//      Skriv ut svaret "Svar: 18"
    
// }

    // let x = 77;
    // x = 55;
    // let y = 44;
    // let z = y+x;
    // console.log(z)

// function var4() {



    
//     Modifera koden du skapat sist och se vilka effekter/felmeddelanden som dyker upp
//     Experimentera!
//     Skapa en variabel "x" med värdet 77
//     Skapa en variabel "y" med värdet 44
//     Ändra värdet av "x" till 55
//     Skapa en variabel "z" som summerar talen
//     Skriv ut summan
    
// }


// const x = 77
// let y = 44
// x = 50
// let z = y+x
// console.log(z)


// function var5() {
    
//      Samma som sist men låter x vara en konstant
//     Vilket felmeddelande dyker upp?

// Uncaught TypeError: Assignment to constant variable.
//     at java.js:58

    
// }

// let nummer1 = "77"
// let nummer2 = "50"
// console.log(nummer1+nummer2)

// function var6() {
    
//     Modifera koden du skapat sist och se vilka effekter/felmeddelanden som dyker upp
//     Experimentera!
//     Skapa en variabel "nummer1" och sätt den till strängen "77" 
//     Skapa en variabel "nummer2" och sätt den till strängen "50"
//     Skriv ut nummer1+nummer2 (ska ge 7750)
    
// }

// let nummer1 = "77"
// let nummer2 = 50
// nummer1 = parseInt(77)

// let nummer1plusnummer2 = nummer1+nummer2
// console.log(nummer1plusnummer2)

// function var7() {
    
//     Skapa en variabel "nummer1" och sätt den till strängen "77" 
//     Skapa en variabel "nummer2" och sätt den till 50
//     Använd parseInt för att omvandla "nummer1" till siffran 77
//     Skriv ut nummer1+nummer2 (ska ge 127)
    
// }

// let Favorittal = "42"
// console.log("Mitt favorittal är " + Favorittal)

// function var8() {
    
//     Skapa variabel nummer med värdet 42. 
//     Skriv ut "Mitt favorittal är 42" (om det är 42).
    
// }

// function var9() {
//      Använd "snedfnutt" för att lösa problemet ovan 
// }

// let middag = "broccoli"
// let Middag = "pasta"



// function var10() {
    
//     Skapa en variabel "middag" och sätt den till 'broccoli'
//     Skapa en variabel "Middag" och sätt den till 'pasta'
//     Meddela värdet av "middag"
    
// }

//let x = 12
//let y = true
//let z = 'måndag'
//let w =

//    console.log(typeof x)
//console.log(typeof y)
//console.log(typeof z)
//console.log(typeof w)



//function var11() {
//    /*
//    Skapa en variabel x med värdet 12
//    Skapa en variabel y med värdet true
//    Skapa en variabel z med värdet 'måndag'
//    Skapa en variabel w utan att sätta något värde
//    Skriv ut typen av dessa fyra variabler mha "typeof"
//    */
//}

//let x = parseInt('oscar')

//isNaN(x)


//function var12() {
//    /*
//    Skapa en variabel "x". Sätt värdet till "parseInt('oscar')"
//    Skriv ut x (ska ge "NaN")
//    Använd "isNaN" fär att kolla om x är ett icke-nummer. Sätt y till det värdet (y kommer få värdet true)
//    Skriv ut y
//    */
//}

//ARRAYER
//_____________________________________________________________________________________________________________________________



//let cities = ["Stockholm", "Göteborg", "NewYork"];

//console.log(cities)
//console.log(cities[0]);
//console.log(cities[1]);
//console.log(cities[2]);
//////console.log(cities[3]);

//function arr1()

//    /*
//        I---------I---------I---------I
//        0         1         2         3
    
//        Skapa en array "cities" med städerna Stockholm, Göteborg och New York
//        Skriv ut det första, andra och tredje elementet i arrayen
//        Vad händer om du försöker komma åt det fjärde elementet (som inte finns)?
//    */
//}

//let cities = ["Stockholm", "Göteborg", "NewYork"];

//cities.push("Krokow")

////console.log(cities)
//console.log(cities[0]);
//console.log(cities[1]);
//console.log(cities[3]);

//function arr2() {

//    /*
//        Skapa en array "cities" med städerna Stockholm, Göteborg och New York
//        Lägg till en till stad "Krakow" mha "push"
//        Skriv ut det fjärde elementet i "cities" ("Krakow")
//    */
//}


//let cities = ["Stockholm", "Göteborg", "NewYork"];
//cities.push("Krokow")
//cities.push("Berlin")

//********************************************************************************

//function arr3() {
//    /*
//        Skapa en array "cities" med städerna Stockholm, Göteborg och New York
//        Lägg till en till stad "Krakow" mha "push"
//        Lägg till ytterligare en till stad "Berlin" mha "push" 
//        Skriv ut "Det finns XXX städer i arrayen"
//        Plocka ut den andra och fjärde staden i listan. Skriv ut "Mina favoritstäder är Göteborg och Krakow"
//    */
//}

//let cities = ["Stockholm", "Göteborg", "NewYork"];

//var x = cities.pop();  

//console.log(x)
//console.log(cities)




//function arr4() {

//    /*
//        Skapa en array "cities" med städerna Stockholm, Göteborg och New York
//        Använd "pop" för att plocka ut den sista staden och placera i en variabel "poppedCity"
//        Skriv ut längen av listan (2)
//        Skriv ut den poppade staden (New York)
//        Använd cities.length för att plocka ut det sista elementet i listan (Göteborg)
//        
//    */
//}





//function arr5() {

//let numbers = [5, 66, 777, 12];
//console.log(numbers.length)
//console.log(numbers[2])
////    /*
////        Skapa en array "numbers" med talen 5,66,777,12
////        Skriv ut antalet nummer i listan (4)
////        Skriv ut det tredje numret i listan (777)
////    */
//}

//function arr6() {

//    /*
//        Skapa en array "numbers" med talen 5,66,777,12
//        Sortera talen genom att skriva: numbers.sort();
//        Sortera talen genom att skriva: numbers.sort( (a,b) => a-b );
//        Skriv ut värdet av "numbers"
//        Jämför de två resultaten
//    */
//}

//function arr7() {

//    /*
//        Sortera listan baklänges
//    */
//    let numbers = [5, 66, 777, 12];
//    numbers.sort((a, b) => b - a);
//    console.log(numbers);

//}

//function arr8() {
    
//    /*
//        Skapa en array "numbers" med talen 5,66,777,12
//        Vänd på ordningen mha "reverse"
//        Skriv ut arrayen ([ 12, 777, 66, 5 ])
//    */
//}



//_____________________________LOOPS___________________________________________________________________
loop1()
function loop1() {

    /*
        Använd en for-loop för att skriva ut alla siffror mellan 5 och 18
    */
    var i;
    for (let i = 5; i <= 18; i++) {
        console.log(i);
    }
}

function loop2() {

    /*
        Använd en for-loop för att skriva ut alla siffror mellan 0 och 9
    */
    for (let i = 0; i < 10; i++) {
        console.log(i);
    }
}

function loop3() {

    /*
        Använd en forloop för att skriva ut:
            "Siffran 4 är tjusig". 
            "Siffran 5 är tjusig"
            "Siffran 6 är tjusig"
            "Siffran 7 är tjusig"
            "Siffran 8 är tjusig"
    */
    for (let i = 4; i <= 8; i++) {
        console.log(`Siffran ${i} är tjusig`);
    }
}

function loop4() {

    /*
        Lös föregående uppgift men använd en while-loop
    */
    let i = 4;
    while (i <= 8) {
        console.log(`Siffran ${i} är tjusig`);
        i++;
    }
}

function loop5() {

    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
        Använd "for of" för att skriva ut alla årtal
    */
    let importantYears = [1492, 1789, 1859, 1929];
    for (let year of importantYears) {
        console.log(year);
    }
}

function loop6() {

    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
	    Använd "for of" för att skriva ut alla årtal med en siffra till vänster:
	    1) 1492
	    2) 1789
	    3) 1859
	    4) 1929
    */
    let rownumber = 1;
    let importantYears = [1492, 1789, 1859, 1929];
    for (let year of importantYears) {
        console.log(`${rownumber}) ${year}`);
        rownumber++;
    }
}

function loop7() {

    /*
	    Samma som sist men avbryt loopen om årtalet är högre än 1800. Ska alltså ge:
	    1) 1492
	    2) 1789
    */
    let rownumber = 1;
    let importantYears = [1492, 1789, 1859, 1929];
    for (let year of importantYears) {
        if (year > 1800) {
            break;
        }
        console.log(`${rownumber}) ${year}`);
        rownumber++;
    }
    
}
