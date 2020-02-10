
function Validate() {
    var password = document.getElementById("txtPassword").value;
    var confirmPassword = document.getElementById("txtConfirmPassword").value;
    console.log("Test");
    console.log(confirmPassword);
    console.log(password);
    if (password != confirmPassword) {
        alert("Passwords do not match.");
        return false;
    }
    return true;
}    
function checkDate() {
    var selectedDate = document.getElementById('datepicker1').value;
    var now = new Date();
    if (selectedDate < now) {
        alert("Date must be in the future");
    }
}
function dateFun() {
    var date = new Date();
    var year = date.getFullYear();
    var month = date.getMonth()+1;
    var day = "0" + date.getDate();
    var fdate = [year, "0" + month, day].join('-');
    console.log(fdate);
    document.getElementById("datepicker").setAttribute("min", fdate);
}