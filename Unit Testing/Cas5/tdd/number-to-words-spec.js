describe("Number to words tests", function () {

    describe("Exception tests", function () {

        it("verifies that empty input results in exception thrown", function () {
            // 1. Arrange
            var input = "";
            // 2. Act
            // 3. Assert
            expect(function () { numberToWords(input); }).toThrow();
        });

        it("verifies that undefined input results in exception thrown", function () {
            // 1. Arrange
            var input = undefined;
            // 2. Act
            // 3. Assert
            expect(function () { numberToWords(input); }).toThrow();
        });

        it("verifies that null input results in exception thrown", function () {
            // 1. Arrange
            var input = null;
            // 2. Act
            // 3. Assert
            expect(function () { numberToWords(input); }).toThrow();
        });

        it("verifies that zero string input results in exception thrown", function () {
            // 1. Arrange
            var input = "0";
            // 2. Act
            // 3. Assert
            expect(function () { numberToWords(input); }).toThrow();
        });
    });

    describe("single digit tests", function () {

        it("verifies that 0 input results in zero output", function () {
            // 1. Arrange
            var input = 0;
            var expected = "zero";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 1 input results in one output", function () {
            // 1. Arrange
            var input = 1;
            var expected = "one";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 2 input results in two output", function () {
            // 1. Arrange
            var input = 2;
            var expected = "two";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 3 input results in three output", function () {
            // 1. Arrange
            var input = 3;
            var expected = "three";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 4 input results in four output", function () {
            // 1. Arrange
            var input = 4;
            var expected = "four";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 5 input results in five output", function () {
            // 1. Arrange
            var input = 5;
            var expected = "five";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 6 input results in six output", function () {
            // 1. Arrange
            var input = 6;
            var expected = "six";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 7 input results in seven output", function () {
            // 1. Arrange
            var input = 7;
            var expected = "seven";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 8 input results in eight output", function () {
            // 1. Arrange
            var input = 8;
            var expected = "eight";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 9 input results in nine output", function () {
            // 1. Arrange
            var input = 9;
            var expected = "nine";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });
    });

    describe("Double digit tests", function () {
        it("verifies that 10 input results in ten output", function () {
            // 1. Arrange
            var input = 10;
            var expected = "ten";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 11 input results in eleven output", function () {
            // 1. Arrange
            var input = 11;
            var expected = "eleven";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 19 input results in nineteen output", function () {
            // 1. Arrange
            var input = 19;
            var expected = "nineteen";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });
    });
    describe("Triple digit tests", function () {
        it("verifies that 100 input results in one hundred output", function () {
            // 1. Arrange
            var input = 100;
            var expected = "one hundred";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 101 input results in one hundred one output", function () {
            // 1. Arrange
            var input = 101;
            var expected = "one hundred one";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 246 input results in two hundred forty six output", function () {
            // 1. Arrange
            var input = 246;
            var expected = "two hundred forty six";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 999 input results in nine hundred ninety nine", function () {
            // 1. Arrange
            var input = 999;
            var expected = "nine hundred ninety nine";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });
    });
    describe("Up to five digit tests", function () {
        it("verifies that 1234 input results in one thousand two hundred thirty four output", function () {
            // 1. Arrange
            var input = 1234;
            var expected = "one thousand two hundred thirty four";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 1000 input results in one thousand output", function () {
            // 1. Arrange
            var input = 1000;
            var expected = "one thousand";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 11000 input results in eleven thousand output", function () {
            // 1. Arrange
            var input = 11000;
            var expected = "eleven thousand";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });

        it("verifies that 999999 input results in nine hundred ninety nine thousand nine hundred ninety nine output", function () {
            // 1. Arrange
            var input = 999999;
            var expected = "nine hundred ninety nine thousand nine hundred ninety nine";
            // 2. Act
            var actual = numberToWords(input);
            // 3. Assert
            expect(actual).toEqual(expected);
        });
    });
});