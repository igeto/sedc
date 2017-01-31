//var userArray = ["admin", "professor", "student", "receptionist"];
//var loginAttempt = prompt ("Please enter your status");

function choice(event) {
	var userChoice = document.getElementById("userType").value;
	
	switch(userChoice) {
		case "admin":
			window.location.href="admin/admin_index.html";
			break;
		case "professor":
			location.href="professor/professor_index.html";
			break;
		case "student":
			window.location.href="student/student_index.html";
			break;
		case "receptionist":
			window.location.href="receptionist/receptionist_index.html";
			break;
		default:
			alert("Please enter one of the choices given above");
	}
}


var homeButton = document.getElementById("homeButton");

homeButton.addEventListener("click", choice);



 var body = document.querySelector("body");
 var isBlue = false;
 setInterval(function(){
 	if (isBlue) {
 		body.style.backgroundColor = "green";
 	}
 	else {
 		body.style.backgroundColor = "red";
 	}
 	isBlue = !isBlue;
 },500)