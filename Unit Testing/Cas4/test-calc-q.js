QUnit.test( "verify that three plus five equals eight", function( assert ) {
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
QUnit.test( "verify that three times five equals fifteen", function( assert ) {
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
QUnit.test( "verify that ten minus seven is three", function( assert ) {
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
QUnit.test( "verify that ten divided by five is two", function( assert ) {
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
QUnit.test( "verify that 10 invalid operator five is zero", function( assert ) {
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
QUnit.test( "verify that three minus negative five is negative two", function( assert ) {
  // Arrange = set up variables
    var first = 3;
    var second = -5;
    var op = "+";
    var expected = -2;
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.equal(actual, expected);
});
QUnit.test( "verify that ten divided by zero is division by zero exception", function( assert ) {
    // Arrange = set up variables
    var first = 10;
    var second = 0;
    var op = "/";
    // Act = execute
    // try {
    //     var actual = calculate(first, second, op);
    //     assert.ok(false);
    // }
    // catch (e) {
    //     assert.ok(true);
    // }
    // Assert = check results
    assert.throws(() => calculate(first, second, op));
});
QUnit.test( "verify that null multiplied by null is zero", function( assert ) {
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
QUnit.test( "verify that zero divided by zero is NaN", function( assert ) {
    // Arrange = set up variables
    var first = 0;
    var second = 0;
    var op = "/";
    var expected = isNaN(NaN);
    // Act = execute
    var actual = calculate(first, second, op);
    // Assert = check results
    assert.ok(isNaN(actual));
});
QUnit.test( "verify that point-one and point-two is point-three", function( assert ) {
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