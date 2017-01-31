// JSON - Javascript Object Notation

function Person(firstName, lastName) {
    this.firstName = firstName;
    this.lastName = lastName;
}

$(document).ready( function() {
    var $txtFirstName = $("#firstName");
    var $txtLastName = $("#lastName");
    var $btnSave = $("#saveButton");
    var $btnClearStorage = $("#clearButton");
    
     if(localStorage.person != null){
        var thePerson = JSON.parse(localStorage.person);
        $txtFirstName.val(thePerson.firstName);
        $txtLastName.val(thePerson.lastName);
    }

    // if(localStorage.lastName != null){
    //     $txtLastName.val(localStorage.lastName);
    // }

    /*
    if(sessionStorage.firstName != null){
        $txtFirstName.val(localStorage.firstName);
    }

    if(sessionStorage.lastName != null){
        $txtLastName.val(localStorage.lastName);
    }
    */
    //   $btnSave.on("click", function(event){
    //     sessionStorage.firstName = $txtFirstName.val();
    //     sessionStorage.lastName = $txtLastName.val();
    // })

    // $btnClearStorage.on("click", function(event){
    //     localStorage.clear();
    // })
    $btnSave.on("click", function(event) {
        var thePerson = new Person($txtFirstName.val(), $txtLastName.val());
        var thePersonStringified = JSON.stringify(thePerson);
        alert(thePersonStringified);
        localStorage.person = thePersonStringified;
    });
});