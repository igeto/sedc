function sayHello(greeting, person) {
    let result = document.getElementById("result");
    let date = new Date();
    date = `${date.getSeconds()}:${date.getMilliseconds()}`;
    result.innerHTML += `${greeting}, ${person}! ${date}<br />`;
}

sayHello("Hi", "Igeto");
// sleep(2);
setTimeout(function() {
    sayHello("Zdravo", "Igor");    
}, 2000);

for (var i = 0; i < 1000000; i++) {
    
}
sayHello("Zdravo", "Igor");
