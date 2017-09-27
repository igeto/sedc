let calc = function (firstParam, secondParam, op) {
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
};
console.log(calc(3, 5, "+"));
