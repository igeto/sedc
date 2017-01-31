$(document).ready(function() {
	var $username = $("#username");
	var $password = $("#password");
	var $login = $("#submit");
	
	$login.on("click", function() {
		var userArray = JSON.parse(localStorage.users);
		var i = 0;
		do {
			if ($username.val() === userArray[i].username && $password.val() === userArray[i].password) {
				window.location.href = "../gallery/gallery.html";
			}
			i++;
	   } while (userArray.length > i);

	  //  for(var i = 0; i < userArray.length; i++){
	  //  		if ($username.val() === userArray[i].username && $password.val() === userArray[i].password) {
			// 	window.location.href = "https://www.google.com/";
			// }
	  //  }

	});
});