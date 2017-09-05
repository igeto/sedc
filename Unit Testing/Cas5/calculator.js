function calculate(first, second, op) {    

    var validOperations = ["*", "/", "+", "-"];
    if (validOperations.indexOf(op) === -1)
        return 0;

    switch (op) {
        case "*":
            return first * second;
        case "+":
            return first + second;
        case "-":
            return first - second;
        case "/":
            if ((second === 0) && (first !== 0)) {
                throw "Division by zero is not allowed";
            }
    
            return first / second;
    };
    
    throw "Invalid operation";
}
