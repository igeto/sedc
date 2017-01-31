let greetings = [
    {
        greeting: "Hi",
        person: "mom"
    },
    {
        greeting: "Hello",
        person: "dad"
    },
    {
        greeting: "How do you do",
        person: "officer"
    }
]

function sayHello() {
    let result = document.getElementById("result");
    result.innerHTML += "<br/><br/>"
    result.innerHTML += `${greetings[1].greeting}, ${greetings[1].person} <br/>`;
    setTimeout(function() {
        result.innerHTML += `${greetings[0].greeting}, ${greetings[0].person} <br/>`;
        setTimeout(function() {
            result.innerHTML += `${greetings[2].greeting}, ${greetings[2].person}`
        }, 4000);
    }, 2000);
    
}
sayHello();