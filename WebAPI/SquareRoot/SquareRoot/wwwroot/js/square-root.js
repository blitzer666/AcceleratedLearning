let errorMessage = "";
let result = "";

function Render() {
    document.getElementById("result").innerText = result;
    document.getElementById("error").innerText = errorMessage;
}

async function squareRoot() {
    let number = document.getElementById("number").value;
  
    let response = await fetch("api/squareroot?number=" +number);
              

    if (response.status === 200) {
        result = await response.json();
        errorMessage = "";

    }
    else if (response.status === 400) {
        result = "";
        errorMessage = await response.text();


    } else {
        errorMessage = "Något gick galet";    
    }
    Render();

   



}