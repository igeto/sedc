type operator = "+" | "-" | "*" | "/";

let calc = function (firstParam: number, secondParam: number, op: operator) {
    switch (op) {
        case "+":
            return firstParam + secondParam;
        case "-":
            return firstParam - secondParam;
        case "*":
            return firstParam * secondParam;
        case "/":
            return Math.floor(firstParam / secondParam);
    }
}
console.log(calc(3, 5, "+"));
