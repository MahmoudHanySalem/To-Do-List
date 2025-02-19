const input = document.querySelector(".input-div form #title");
const addbtn = document.getElementById("addbtn");
const tasksDiv = document.querySelector(".tasks");

document.addEventListener("DOMContentLoaded", function () {
    window.scrollTo({
        top: document.body.scrollHeight,
    });
});

function edit() {
    if (event.target.classList.contains('editbtn') || event.target.classList.contains('cancel-button')) {
        const current = event.target;
        if (current.innerHTML == "Edit") {
            const idField = document.querySelector(".input-div form #taskId");
            idField.value = current.parentElement.parentElement.getAttribute("data-id");
            input.value = Array.from(current.parentElement.parentElement.childNodes).filter(node => node.nodeType === Node.TEXT_NODE).map(node => node.textContent.trim()).join('');
            input.focus();
            addbtn.innerHTML = `<div class="button-img">
                <img src="images/icon/ic--baseline-edit.svg" alt="editing icon">
                </div>
                Add Edited Task`;
            current.innerHTML = "Cancel";
            current.className = "cancel-button";
        } else {
            input.value = '';
            input.blur();
            addbtn.innerHTML = `<div class="button-img">
                <img src="images/icon/majesticons--plus.svg" alt="plus icon">
                </div>
                Add New Task`;
            current.innerHTML = "Edit";
            current.classList.remove("cancel-button");
            current.classList.add("editbtn");
        }
    }
}


addbtn.addEventListener('click', (event) => {
    if(input.value==="") return;
    if (addbtn.textContent.includes("Add New Task")) {
        let element = document.createElement("div");
        element.className = "task";
        element.textContent = input.value;
        element.setAttribute("data-id", taskIdFromBackend);

        let editbtn = document.createElement("button");
        editbtn.className = "editbtn";
        editbtn.innerHTML = "Edit";
        let delbtn = document.createElement("button");
        delbtn.className = "delbtn";
        delbtn.innerHTML = "Delete";

        let btnDiv = document.createElement("div");
        btnDiv.className = "btn-div";

        btnDiv.appendChild(editbtn);
        btnDiv.appendChild(delbtn);
        element.appendChild(btnDiv);
        tasksDiv.appendChild(element);

        input.value = '';

    } 
});
