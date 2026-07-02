const categoriesDiv = document.getElementById("categories");

async function loadData() {
  try {
    var token = localStorage.getItem("token");


    var response = await axios.get("http://localhost:5023/api/Categories", {
      headers:{
        Authorization: "Bearer " + token
      }
    });



    response.data.forEach((element) => {
      categoriesDiv.innerText += element.name + "\n";
    });
  } catch (error) {
    console.log(error);
  }
}

loadData();
