byId("addForm").style.display = "none"
byId("updateForm").style.display = "none"


function showAddNews() {
    document.getElementById("addForm").style.display = "block";
}
function showUpdateNews() {
    document.getElementById("updateForm").style.display = "block";
}

async function getNewsTable() {

    //tHead.style.display = "block";

    let response = await fetch("api/News", {
        method: "get",

    });


    if (response.status === 200) {
        let allNews = await response.json();
        console.log(allNews);
        let html = "";
        for (let news of allNews) {

            html +=
                `<tr>
<td>${news.id}</td>
<td>${news.header}</td>
<td>${news.creatDatTime}</td>
<td>${news.updatedDate}</td>
<td> <button onclick="showUpdateTable()">Update</button></td>
<td> <button onclick="deleteNews(${news.id})">x</button></td>
</tr>`
        }

        byId("newsTableBody").innerHTML = html;



    }
    else {
        console.log("Unexpected error", response);
    }


}




async function addNews() {

    let response = await fetch("api/News", {
        method: "POST",
        body: JSON.stringify({
            Header: byId("addFormHeader").value,
            Intro: byId("intro").value,
            Body: byId("body").value,
        }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    if (response.status === 200) {
        let id = await response.json();
        console.log(`News with id = ${id} added`);

    } else {
        console.log("Unexpected error", response);
    }

}
async function updateNews() {

    let response = await fetch("api/News/update", {
        method: "PUT",
        body: JSON.stringify({
            id: byId("updateFormId").value,
            header: byId("updateFormHeader").value,
            Intro: byId("updateFormIntro").value,
            body: byId("updateFormBody").value,
            
        }),
        headers: {
            "Content-Type": "application/json"
        }
    });

 
    if (response.status === 200) {
        let id = await response.json();
        console.log(`News with id = ${id} added`);

    } else {
        console.log("Unexpected error", response);
    }

}

async function recreate() {
    // fetch "api/News/Recreate" med POST
    let response = await fetch("api/news/recreate", {
        method: "POST"
    });

    if (response.status === 200) {
        alert("Allt gick bra!");
    }
    else {
        alert("Något gick fel")
    }


}



function byId(id) {
    return document.getElementById(id);
}