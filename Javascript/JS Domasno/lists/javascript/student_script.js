function showFirstGrades() {
	var temp = document.getElementsByClassName("firstGrades");
    for(var i = 0; i < temp.length; i++)
        temp[i].classList.toggle("mirror");
}
function showSecondGrades() {
	var temp = document.getElementsByClassName("secondGrades");
    for(var i = 0; i < temp.length; i++)
        temp[i].classList.toggle("mirror");
}
function showThirdGrades() {
	var temp = document.getElementsByClassName("thirdGrades");
    for(var i = 0; i < temp.length; i++)
        temp[i].classList.toggle("mirror");
}
function showFourthGrades() {
	var temp = document.getElementsByClassName("fourthGrades");
    for(var i = 0; i < temp.length; i++)
        temp[i].classList.toggle("mirror");
}
function showFifthGrades() {
	var temp = document.getElementsByClassName("fifthGrades");
    for(var i = 0; i < temp.length; i++)
        temp[i].classList.toggle("mirror");
}
function showSixthGrades() {
	var temp = document.getElementsByClassName("sixthGrades");
    for(var i = 0; i < temp.length; i++)
        temp[i].classList.toggle("mirror");
}

var firstStudent = document.getElementById("firstStudent");
firstStudent.addEventListener("mouseover", function(){showFirstGrades()});
firstStudent.addEventListener("mouseout", function(){showFirstGrades()});

var secondStudent = document.getElementById("secondStudent");
secondStudent.addEventListener("mouseover", function(){showSecondGrades()});
secondStudent.addEventListener("mouseout", function(){showSecondGrades()});

var thirdStudent = document.getElementById("thirdStudent");
thirdStudent.addEventListener("mouseover", function(){showThirdGrades()});
thirdStudent.addEventListener("mouseout", function(){showThirdGrades()});


var fourthStudent = document.getElementById("fourthStudent");
fourthStudent.addEventListener("mouseover", function(){showFourthGrades()});
fourthStudent.addEventListener("mouseout", function(){showFourthGrades()});

var fifthStudent = document.getElementById("fifthStudent");
fifthStudent.addEventListener("mouseover", function(){showFifthGrades()});
fifthStudent.addEventListener("mouseout", function(){showFifthGrades()});

var sixthStudent = document.getElementById("sixthStudent");
sixthStudent.addEventListener("mouseover", function(){showSixthGrades()});
sixthStudent.addEventListener("mouseout", function(){showSixthGrades()});