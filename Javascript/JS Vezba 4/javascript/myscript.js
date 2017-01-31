function printArray (inputArray) {
	for (var i = 0; i < inputArray.length; i++) {
		if (i === inputArray.length - 1) {
			document.write (inputArray[i] + ".");
		}
		else {
			document.write (inputArray[i] + ", ");
		}			
	}
	document.write ("<br />");
}

function replaceTwoNumbers (inputArray, number, replacementNumber) {
	for (var i = 0; i < inputArray.length; i++) {
		if (inputArray[i] == number) {
			inputArray[i] = replacementNumber;
		}
		if (i === inputArray.length - 1) {
			document.write (inputArray[i] + ".");
		}
		else {
			document.write (inputArray[i] + ", ");
		}			
	}
}

var inputArray = [1, 4, 6, 1, 6, 8, 0, 1, 7, 3, 9, 5, 5, 4];
var elemToReplace = prompt ("Please enter one digit number");
var substitutionElem = prompt ("Please enter one digit number");

printArray (inputArray);
replaceTwoNumbers (inputArray, elemToReplace, substitutionElem);