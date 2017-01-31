function Person(firstName, lastName, age, email, password) {
	this.firstName = firstName;
	this.lastName = lastName;
	this.age = age;
	this.email = email;
	this.password = password;
}

$(document).ready(function() {
	var $firstName = $("#firstName");
	var $lastName = $("#lastName");
	var $age = $("#age");


	var $email = $("#email");
	var $password = $("#password");
	var $submitButton = $("#saveButton");
	var $clearButton = $("#clearButton");

	// if (localStorage.person != null) {
	// 	var thePerson = 
	// }
	
	$submitButton.on("click", function(event) {
			var thePerson = new Person($firstName.val(), $lastName.val(), $age.val(), $email.val(), $password.val());
			var thePersonStringed = JSON.stringify(thePerson);
			localStorage.person = thePersonStringed;
			
	});
	$clearButton.on("click", function(event) {
		localStorage.clear();
	});
});