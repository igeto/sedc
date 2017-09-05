function assert(actual, expected, name) {
    if (actual === expected) {
        console.log(`OK: (${name})`);
    } else {
        console.error(`NOT OK: (${name}) Expected ${expected}, but gotten ${actual}`);
    }
}

((name)=>{
    // Arrange = set up variables
    var first = 3;
    var second = 5;
    var op = "+";
    var expected = 8;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that three plus five equals eight");

((name)=>{
    // Arrange = set up variables
    var first = 3;
    var second = 5;
    var op = "*";
    var expected = 15;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that three times five equals fifteen");

(()=>{
    // Arrange = set up variables
    var first = 10;
    var second = 7;
    var op = "-";
    var expected = 3;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected);
})();

(()=>{
    // Arrange = set up variables
    var first = 10;
    var second = 5;
    var op = "/";
    var expected = 2;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected);
})();

(()=>{
    // Arrange = set up variables
    var first = 10;
    var second = 5;
    var op = "invalid";
    var expected = 0;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected);
})();

((name)=>{
    // Arrange = set up variables
    var first = 3;
    var second = -5;
    var op = "+";
    var expected = -2;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that three plus (minus five) equals (minus two)");

((name)=>{
    // Arrange = set up variables
    var first = 10;
    var second = 0;
    var op = "/";
    var expected = Infinity;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that ten divided by zero equals Infinity");
