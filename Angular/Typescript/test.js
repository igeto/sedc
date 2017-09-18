var calc = function (firstParam, secondParam, op) {
    switch (op) {
        case "+":
            return console.log(firstParam + secondParam);
        case "-":
            return console.log(firstParam - secondParam);
        case "*":
            return console.log(firstParam * secondParam);
        case "/":
            return console.log(Math.floor(firstParam / secondParam));
        default:
            return console.log("Whatever");
    }
};
calc(3, 5, "+");
