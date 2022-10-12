function resetInfo(){
    document.getElementById("startDate").value = "";
    document.getElementById("endDate").value = "";
    document.getElementById("ETA").style.opacity = "0";
    document.getElementById("ETA").value = "14:00:00";
    document.getElementById("ETALabel").style.opacity = "0";
    document.getElementById("errorMessage").style.display = "none";
    document.getElementById("roomType").value = "";
    document.getElementById("noRooms").value = "1";
    document.getElementById("noAdults").value = "1";
    document.getElementById("noChildren").value = "0";
    document.getElementById("breakfast").checked = false;
    document.getElementById("yourStayPrice").textContent = "$";
    document.getElementById("titleDropList").value = "ms";

    var i;
    var textboxes = document.getElementsByClassName("guessInfoTextBox");
    for (i = 0; i < textboxes.length; i++) {
        textboxes[i].value = "";
    }
    document.getElementById("adderror").style.display = "none";
    document.getElementById("fnameerror").style.display = "none";
    document.getElementById("lnameerror").style.display = "none";
    document.getElementById("phoneerror").style.display = "none";
}

function validDateCheck(startDate, endDate){
    //get current date code from:
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1;
    var yyyy = today.getFullYear();

    if(dd < 10) {
        dd = '0' + dd;
    }

    if(mm < 10) {
        mm = '0' + mm;
    }

    today = yyyy + '-' + mm + '-' + dd;

    if (endDate === ""){
        if (startDate < today){
            return false;
        }
        return true;
    }

    if (startDate < today || endDate === today || enddate === startDate || startDate > endDate){
        return false;
    }else{
        return true;
    }
}

function updatePrice(){
    var roomType = document.getElementById("roomType").value;
    var noRooms = document.getElementById("noRooms").value;
    var startDate = document.getElementById("startDate").value;
    var endDate = document.getElementById("endDate").value;
    var noAdult = document.getElementById("noAdults").value;
    var noChildren = document.getElementById("noChildren").value;
    var breakfast = document.getElementById("breakfast").value;
    var price = 0;
    var breakfastPrice = 35;

    if(startDate === "" || endDate === "" || roomType === ""){return;}

    startDate = new Date(startDate);
    endDate = new Date(endDate);

    var dayDiff = endDate.getTime() - startDate.getTime();

    dayDiff /= 1000;
    dayDiff /= 60;
    dayDiff /= 60;
    dayDiff /= 24;

    //get Room Price
    price = roomType;

    //get number of rooms price
    price *= parseInt(noRooms);

    //get Breakfast price
    var temPrice = price;
    var totalBreakfastPrice = 0;
    if (breakfast){
        totalBreakfastPrice = breakfastPrice * parseInt(noAdult);
        totalBreakfastPrice += breakfastPrice * parseInt(noChildren);
        price += totalBreakfastPrice;
    }else{
        price = temPrice;
    }
    price *= dayDiff;
    document.getElementById("yourStayPrice").textContent = '$' + price.toString();
}

function inputCheck(){
    var firstname = document.getElementById("firstname").value;
    var lastname = document.getElementById("lastname").value;
    var address = document.getElementById("address").value;
    var phone = document.getElementById("phone").value;

    document.getElementById("fnameerror").innerHTML = "";
    document.getElementById("lnameerror").innerHTML = "";
    document.getElementById("adderror").innerHTML = "";
    document.getElementById("phoneerror").innerHTML = "";

    var email = document.getElementById("email").value;
    var mailformat = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;

    if (!email.match(mailformat)){
        alert("Must enter a valid email address");
        document.customerInfoForm.email.focus();
        if(firstname === "" || firstname === null){
            document.getElementById("fnameerror").innerHTML = "Please enter a first name";
        }
        if(lastname === "" || lastname === null){
            document.getElementById("lnameerror").innerHTML = "Please enter a last name";
        }
        if(address === "" || address === null){
            document.getElementById("adderror").innerHTML = "Please enter an address";
        }
        if(phone === "" || phone === null){
            document.getElementById("phoneerror").innerHTML = "Please enter a phone number";
        }
    }else{
        alert("Thanks for submitting your form");
        resetInfo();
    }
}

function dateInput() {
    var startDate = document.getElementById("startDate").value;
    var endDate = document.getElementById("endDate").value;
    var ETA = document.getElementById("ETA").value;
    var ETALabel = document.getElementById("ETALabel").value;

    if (startDate !== ""){
        var validDate = validDateCheck(startDate, endDate);

        if(!validDate){
            document.getElementById("errorMessage").style.display = "block";
            ETA.style.opacity = "0";
            ETALabel.style.opacity = "0";
        }else{
            document.getElementById("errorMessage").style.display = "none";
        }

        if (endDate !== ""){
            validDate = validDateCheck(startDate, endDate);
            if (validDate){
                document.getElementById("errorMessage").style.display = "none";
                ETA.style.opacity = "100";
                ETALabel.style.opacity = "100";
            }else{
                document.getElementById("errorMessage").style.display = "block";
                ETA.style.opacity = "0";
                ETALabel.style.opacity = "0";
            }
        }  
    }
}