function updatePrice() {
    let qty = document.getElementById("qty").value;
    console.log(qty);
    let price = document.getElementById("coffee").value;
    console.log(price);
    let total = qty * price;
    document.getElementById("totalPrice").textContent = '$' + total.toString();
}

function updatePriceTable() {
    let fwQty = document.getElementById("fwQty").value;
    let lQty = document.getElementById("lQty").value;
    let icQty = document.getElementById("icQty").value;
    let ichocQty = document.getElementById("ichocQty").value;

    let fwprice = document.getElementById("fwPrice").innerHTML;
    let lprice = document.getElementById("lPrice").innerHTML;
    let icprice = document.getElementById("icPrice").innerHTML;
    let ichocprice = document.getElementById("ichocPrice").innerHTML;

    let fwtotal = fwQty * fwprice;
    let ltotal = lQty * lprice;
    let ictotal = icQty * icprice;
    let ichoctotal = ichocQty * ichocprice;

    let total = fwtotal + ltotal + ictotal + ichoctotal;
    document.getElementById("fwTotal").textContent = '$' + fwtotal.toString();
    document.getElementById("lTotal").textContent = '$' + ltotal.toString();
    document.getElementById("icTotal").textContent = '$' + ictotal.toString();
    document.getElementById("ichocTotal").textContent = '$' + ichoctotal.toString();
    document.getElementById("total").textContent = '$' + total.toString();
}

function inputCheck() {
    var firstname = document.getElementById("firstname").value;
    var lastname = document.getElementById("lastname").value;
    var address = document.getElementById("address").value;
    var phone = document.getElementById("phoneNo").value;

    document.getElementById("fnameerror").innerHTML = "";
    document.getElementById("lnameerror").innerHTML = "";
    document.getElementById("adderror").innerHTML = "";
    document.getElementById("phoneerror").innerHTML = "";

    var email = document.getElementById("email").value;
    var mailformat = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    if (!email.match(mailformat)) {
        alert("Must enter a valid email address");
        document.customerInfoForm.email.focus();
        return false;
    }
    if (firstname === "" || firstname === null) {
        document.getElementById("fnameerror").innerHTML = "Please enter a first name";
        return false;
    }
    if (lastname === "" || lastname === null) {
        document.getElementById("lnameerror").innerHTML = "Please enter a last name";
        return false;
    }
    if (address === "" || address === null) {
        document.getElementById("adderror").innerHTML = "Please enter an address";
        return false;
    }
    if (phone === "" || phone === null) {
        document.getElementById("phoneerror").innerHTML = "Please enter a phone number";
        return false;
    }
    alert("Thanks for submitting your form");
    resetInfo();
}

function resetInfo() {
    document.getElementById("titleDropList").value = "ms";
    var i;
    var textboxes = document.getElementsByClassName("guestInfoTextBox");
    for (i = 0; i < textboxes.length; i++) {
        textboxes[i].value = "";
    }
    document.getElementById("adderror").style.display = "none";
    document.getElementById("fnameerror").style.display = "none";
    document.getElementById("lnameerror").style.display = "none";
    document.getElementById("phoneerror").style.display = "none";
}