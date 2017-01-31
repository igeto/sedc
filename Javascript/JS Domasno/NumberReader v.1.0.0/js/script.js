function splitNumber (num) {
	var number = parseInt(num);
	if (number === 0) {numArray.unshift(number);}
	while (number > 0) {
		temp = number % 10;
		number = Math.floor(number / 10);
		numArray.unshift(temp);
	}
	return numArray;
}
function stringNumber(numArray) {
	var stringedNumber = "";
	var endsCounter = (Math.ceil(numArray.length / 3) - 1);
	for (var i = 0; i < numArray.length; i++) {
		for (var j = 0; j < ones.length; j++) {
			if (numArray[i] === j && j != 0) {
				if ((numArray.length - i) % 3 === 0 ) {	
					stringedNumber += ones[j] + " " + ends[0] + " ";
				} else if ((numArray.length - i + 1) % 3 === 0 && numArray[i] != 1) {
					stringedNumber += tens[j] + " ";
				} else if ((numArray.length - i + 1) % 3 === 0 && numArray[i] === 1) {
					for (var k = 0; k < ones.length; k++) {
						if (numArray[i + 1] === k) {
							stringedNumber += special[k] + " ";
							if (endsCounter != 0) {
								stringedNumber += ends[endsCounter] + " ";
								endsCounter--;
							}
						}
					}
					i++;
				} else if ((numArray.length - i - 1) % 3 === 0 && endsCounter != 0 && numArray[i - 1] != 1) {
					stringedNumber += ones[j] + " " + ends[endsCounter] + " ";
					endsCounter--;
				} else if ((numArray.length - i - 1) % 3 === 0 && endsCounter === 0 && numArray[i - 1] != 1) {
					stringedNumber += ones[j];
				}
			} else if (numArray[i] === 0 && (numArray.length - i - 1) % 3 === 0 && endsCounter != 0 && numArray[i - 1] != 1){
				if (numArray[i] + numArray[i - 1] + numArray[i - 2] != 0)
					stringedNumber += ends[endsCounter] + " ";
				endsCounter--;
			} 
			if (numArray.length === 1 && numArray[0] === 0) {
				stringedNumber = ones[0];
			}
		}
	}
	return stringedNumber;
}
var ones = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
var tens = ["zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"];
var special = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
var ends = ["hundred", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octilion", "nontillion", "decillion"];
var getNumber = document.getElementById("button");
var numArray = [];

getNumber.addEventListener("click", function() {
	var number = document.getElementById("inputField").value;
	splitNumber(number);
	var stringedNumber = stringNumber(numArray);
	document.getElementById("stringedNumber").innerHTML = stringedNumber;
	document.getElementById("inputField").value = "";
	numArray = [];
	stringedNumber = "";
});