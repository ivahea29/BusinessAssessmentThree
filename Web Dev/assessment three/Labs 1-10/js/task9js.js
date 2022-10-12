// 1.
var stuName = "Ivan";
// 2. 
var num = 60;

function myFunction1(){
    // 3.
    var x = 10;
    var y = 15;
    document.getElementById("sum").innerHTML = x + y;
    // 4.
    var z = x + y;
    alert(z);
}

// 5.
var firstName = "Ivan", lastName = "Heaslip", groupName = "WildTimeZoo";
// 6.
let length = 16; //Number
let LastName = "Heaslip"; //string
const x = {
    firstName: "Finn", //object
    lastName: "Finn"
};
// 7.
function testFunction(){
    var test = "This is an alert from testFunction";
    alert(test);
}
testFunction();
// 8.
function helloFunction(){
    document.getElementById("heading").innerHTML = "Hello World";
}
// 10.
function lengthFunction(){
    let text = "Hello World";
    let lngth = text.length;

    document.getElementById("length").innerHTML = lngth;
}
