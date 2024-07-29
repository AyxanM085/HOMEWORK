let container = document.getElementById("div");
let input = document.getElementById("input-find");
let findButton = document.getElementById("find-btn");

const myURL = "https://fakestoreapi.com/products/";

findButton.addEventListener("click", function () {
    fetch(myURL+input.value)
    .then((data) => data.json())
    .then(
      (data) =>
        (container.innerHTML = `
        <img src="${data.image}" class="card-img-top" alt="...">
        <div class="card-body">
          <h5 class="card-title">${data.description}</h5>
          <p class="card-text">${data.id}</p>
        </div>
        <ul class="list-group list-group-flush">
          <li class="list-group-item">Follower: ${data.followers}</li>
          <li class="list-group-item">Follower: ${data.following}</li>
          <li class="list-group-item">Public Repos: ${data.public_repos}</li>
        </ul>
        <div class="card-body">
          <a href="${data.html_url}" class="card-link">Github profile</a>
          <a href="${data.avatar_url}" download class="card-link">Download picture</a>
        </div>`)
    );
});
