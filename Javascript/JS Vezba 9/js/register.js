function User(firstName, lastName, username, password, email, birthday, city, hobbies) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.username = username;
    this.password = password;
    this.email = email;
    this.birthday = birthday;
    this.city = city;
    this.hobbies = hobbies;
}

$(document).ready(function() {
    var $firstName = $("#firstName");
    var $lastName = $("#lastName");
    var $username = $("#username");
    var $password = $("#password");
    var $confirmPassword = $("#confirmPassword");
    var $email = $("#email");
    var $birthday = $("#birthday");
    var $city = $("#city");
    var $hobbies = $("#hobbies");
    var $submitButton = $("#submit");
    var $resetButton = $("#reset");
    var userArray = [];

    if (localStorage.users != null) {
        userArray = JSON.parse(localStorage.users);
    }

    $submitButton.on("click", function(event) {
        event.preventDefault();
        if ($confirmPassword.val() === $password.val()) {
            var theUser = new User($firstName.val(), $lastName.val(), $username.val(), $password.val(), $email.val(), $birthday.val(), $city.val(), $hobbies.val());
            userArray.push(theUser);
            localStorage.users = JSON.stringify(userArray);
        } else {
            alert("Your passwords do not match");
        }
    });
    
});