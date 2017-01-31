$(document).ready(function() {
	function User(username, password) {
		this.username = username;
		this.password = password;
	}

	var $inputUsername = $("<input>");
	$inputUsername.attr("type", "text");
	$inputUsername.attr("id", "username");

	var $inputPassword = $("<input>");
	$inputPassword.attr("type", "password");
	$inputPassword.attr("id", "password");

	var $button = $("<button>");
	$button.attr("type", "submit");
	$button.attr("id", "submit");
	$button.text("Submit");

	$("body").append($inputUsername);
	$("body").append($inputPassword);
	$("body").append($button);

	$button.on("click", function() {
		var newUser = new User($inputUsername.val(), $inputPassword.val());
		var newUserStringified = JSON.stringify(newUser);
		localStorage.user = newUserStringified;
		$inputUsername.val() = $("");
	});
});