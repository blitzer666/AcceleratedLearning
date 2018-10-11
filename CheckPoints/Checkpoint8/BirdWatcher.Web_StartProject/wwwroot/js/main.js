async function getInfoTable() {
    let response = await fetch("observation", {
        method: "get",

    });


    if (response.status === 200) {
        let allInfo = await response.json();






        let html = `<table>     

                <td style = "color:SkyBlue;">Date</td>
                <td style="color:SkyBlue;">Specie</td>
                <td style="color:SkyBlue;">Location</td>
                <td style="color:SkyBlue;">Notes</td>
                `;
        for (let observation of allInfo) {



            html +=
                `

                <tr>    
                    <td>${observation.date}</td>
                    
                    <td>${observation.specie}</td>
                    
                    <td>${observation.location}</td>
                    
                    <td>${observation.notes}</td>

                </tr>
                `



        }
        html += "</table>";

        byId("allInfo").innerHTML = html;



    }
    else {
        console.log("Unexpected error", response);
    }


}
async function getBirdTable() {
    let response = await fetch("observation", {
        method: "get",



    });


    if (response.status === 200) {
        let allBirds = await response.json();




        let html = "<table>";
        for (let observation of allBirds) {

            html +=
                `
                <tr>

                    <td>${observation.specie}</td>

                </tr>

                `



        }
        html += "</table>";

        byId("allBirds").innerHTML = html;



    }
    else {
        console.log("Unexpected error", response);
    }


}

async function addObservation() {

    let response = await fetch("observation", {
        method: "POST",
        body: JSON.stringify({
            Date: byId("date").value,
            Specie: byId("specie").value,
            location: byId("location").value,
            Notes: byId("notes").value,
        }),
        headers: {
            "Content-Type": "application/json"
        }
    });



    if (response.status === 200) {

        let id = await response.json();
        console.log(`Observation with id = ${id} added`);
        document.getElementById("specie").value = ""
        document.getElementById("location").value = ""
        document.getElementById("date").value = ""
        document.getElementById("notes").value = ""
        getBirdTable();
        getInfoTable();

    } else {
        console.log("Unexpected error", response);
    }

}


async function recreateDatabase() {
    document.getElementById("recreateButton").style.display = "none";
    document.body.style.backgroundColor = "blue";

    let response = await fetch("/observation/recreate", {
        method: "POST"
    });

    if (response.status === 200) {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "green";

    } else {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "red";

    }

}
function byId(id) {
    return document.getElementById(id);
}

getInfoTable();
getBirdTable();