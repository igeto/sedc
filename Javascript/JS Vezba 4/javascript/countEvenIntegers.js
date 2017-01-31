function countEvenIntegers (array) {
	var counter = 0;
	for (var i = array.length - 1; i >= 0; i--) {
		if (array[i] % 2 === 0) {
			counter++;
		}
	}
		return counter;
}

function fillArray () {
	var randomArray = [];
	var arraySize = parseInt (prompt ("Please enter the size of your array"));
	
	for (var i = 0; i < arraySize; i++) {
		randomArray[i] = parseInt (prompt ("Please enter a value for your array"));
	}
	document.write ("Your array is: " + randomArray + "<br />");
	var numberOfEvens = countEvenIntegers (randomArray);
	document.write ("Your have " + numberOfEvens + " even numbers in your array");
}

fillArray ();