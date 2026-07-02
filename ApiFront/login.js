const emailInpt = document.getElementById("emailInpt")
const passwordInpt = document.getElementById("passwordInpt")
const submitBtn = document.getElementById("submitBtn")

submitBtn.addEventListener("click", async function(event){
    event.preventDefault();
    var emailValue = emailInpt.value;
    var passwordValue = passwordInpt.value;
    var body = {
        email: emailValue,
        password: passwordValue
    }
    var response = await axios.post("http://localhost:5023/api/Account/login", body);
    localStorage.setItem("token", response.data);
    window.location.href = "index.html"
});