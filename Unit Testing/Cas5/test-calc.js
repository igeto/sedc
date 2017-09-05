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

((name)=>{
    // Arrange = set up variables
    var first = 10;
    var second = 7;
    var op = "-";
    var expected = 3;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that ten minus seven is three");

((name)=>{
    // Arrange = set up variables
    var first = 10;
    var second = 5;
    var op = "/";
    var expected = 2;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that ten divided by five is two");

((name)=>{
    // Arrange = set up variables
    var first = 10;
    var second = 5;
    var op = "invalid";
    var expected = 0;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that invalid operation returns zero");

((name)=>{
    // Arrange = set up variables
    var first = null;
    var second = null;
    var op = "*";
    var expected = 0;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that operation of null operands returns zero");

((name)=>{
    // Arrange = set up variables
    var first = 10;
    var second = 0;
    var op = "*";
    var expected = 0;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that multiplication with zero returns zero");

((name)=>{
    // Arrange = set up variables
    var first = 0.1;
    var second = 0.2;
    var op = "+";
    var expected = 0.3;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    // assert(actual, expected, name);
})("verify that point-one and point-two are point-three");

((name)=>{
    // Arrange = set up variables
    var first = 3;
    var second = 0;
    var op = "/";
    var expected = Infinity;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that three divided by zero is infinity");

((name)=>{
    // Arrange = set up variables
    var first = -3;
    var second = 0;
    var op = "/";
    var expected = -Infinity;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that -three divided by zero is -infinity");

((name)=>{
    // Arrange = set up variables
    var first = 0;
    var second = 0;
    var op = "/";
    var expected = NaN;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert(actual, expected, name);
})("verify that zero divided by zero is NaN");

