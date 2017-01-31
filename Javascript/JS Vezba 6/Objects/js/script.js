var students = [];


function addNewStudent() {
	var theStudent = new Student(document.getElementById("firstName").value, document.getElementById("lastName").value, document.getElementById("age").value, document.getElementById("grade").value)
	students.push(theStudent);
	var addedStudent = document.getElementsByName("inputField");
	for (var i = 0; i < addedStudent.length; i++) {
		addedStudent[i].value = "";
	}
}
function Student (firstName, lastName, age, grade) {
	this.firstName = firstName;
	this.lastName = lastName;
	this.age = age;
	this.grade = grade;
}

function calculateAverageGrade() {
	var average;
	var sum = 0;
	for (var i = 0; i < students.length; i++) {
		sum += parseInt(students[i].grade);
	}
	average = sum / students.length;
	alert(average);
}



var averageGrade = document.getElementById("averageGrade");
averageGrade.addEventListener("click", calculateAverageGrade)
var btn = document.getElementById("submit");
btn.addEventListener("click", addNewStudent);
