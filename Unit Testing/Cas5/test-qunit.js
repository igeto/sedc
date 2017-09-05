QUnit.assert.closeEnough = function (actual, expected, error, message) {
    if (error === void 0 || error === null) {
        error = 0.00001 // default error
    }

    var result = actual == expected 
        || (actual < expected + error && actual > expected - error) 
        || false;

    this.push(result, actual, expected, message);
};

QUnit.test("verify that three plus five equals eight", function (assert) {
    // Arrange = set up variables
    var first = 3;
    var second = 5;
    var op = "+";
    var expected = 8;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.equal(actual, expected);
});

QUnit.test("verify that three times five equals fifteen", function (assert) {
    // Arrange = set up variables
    var first = 3;
    var second = 5;
    var op = "*";
    var expected = 15;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.equal(actual, expected);
});

QUnit.test("verify that ten minus seven is three", function (assert) {
    // Arrange = set up variables
    var first = 10;
    var second = 7;
    var op = "-";
    var expected = 3;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.equal(actual, expected);
});

QUnit.test("verify that ten divided by five is two", function (assert) {
    // Arrange = set up variables
    var first = 10;
    var second = 5;
    var op = "/";
    var expected = 2;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.equal(actual, expected);
});

QUnit.test("verify that invalid operation returns zero", function (assert) {
    // Arrange = set up variables
    var first = 10;
    var second = 5;
    var op = "invalid";
    var expected = 0;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.equal(actual, expected);
});

QUnit.test("verify that operation of null operands returns zero", function (assert) {
    // Arrange = set up variables
    var first = null;
    var second = null;
    var op = "*";
    var expected = 0;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.equal(actual, expected);
});

QUnit.test("verify that multiplication with zero returns zero", function (assert) {
    // Arrange = set up variables
    var first = 10;
    var second = 0;
    var op = "*";
    var expected = 0;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.equal(actual, expected, name);
});

QUnit.test("verify that zero divided by zero is NaN", function (assert) {
    // Arrange = set up variables
    var first = 0;
    var second = 0;
    var op = "/";
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.ok(isNaN(actual));
});

QUnit.test("verify that non-zero divided by zero throws exception", function (assert) {
    // Arrange = set up variables
    var first = 3;
    var second = 0;
    var op = "/";
    // Act, Assert
    assert.throws(() => calculate(first, second, op));
});

QUnit.test("verify that point-one and point-two are point-three", function (assert) {
    // Arrange = set up variables
    var first = 0.1;
    var second = 0.2;
    var op = "+";
    var expected = 0.3;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.closeEnough(actual, expected);
});