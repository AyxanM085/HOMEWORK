function addTodo() {
    var input = document.getElementById("todo-input");
    var todoText = input.value.trim();

    if (todoText === "") {
        alert("Error: Please enter a todo!");
        return;
    }

    var ul = document.getElementById("todo-list");
    var li = document.createElement("li");
    li.textContent = todoText;

    var deleteBtn = document.createElement("button");
    deleteBtn.textContent = "Delete";
    deleteBtn.className = "delete-btn";
    deleteBtn.onclick = function() {
        ul.removeChild(li);
    };

    li.appendChild(deleteBtn);
    ul.appendChild(li);

    input.value = "";
}
