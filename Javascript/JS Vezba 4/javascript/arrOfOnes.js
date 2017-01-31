function howManyOnes (inputNumber) {
	for (var i = inputNumber - 1; i >= 0; i--) {
		if (i === 0) {
			document.write ("1.");
		}
		else {
			document.write ("1, ");
		}
	}
}


var inputNumber = parseInt (prompt ("Please enter a number"));

howManyOnes (inputNumber);