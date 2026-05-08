let cards = document.getElementById("cards");

let GetDataFromApi = async () => {
  let res = await fetch("https://fakestoreapi.com/products");
  let datas = await res.json();

  datas.forEach((data) => {
    cards.innerHTML += `
    <div class="card" style="width: 18rem">
        <img src="${data.image}" class="card-img-top" alt="..." />
        <div class="card-body">
          <h5 class="card-title">${data.title}</h5>
          <p class="card-text">
            ${data.description}
          </p>
          <a href="#" class="btn btn-primary">Price ${data.price}</a>
        </div>
      </div>`;
  });
};

GetDataFromApi();
