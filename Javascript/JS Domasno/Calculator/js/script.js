function addToNumber() {
	switch (operation) {
			case "+": 
				result = number1 + number2;
				break;
			case "-":
				result = number1 - number2;
				break;
			case "*":
				result = number1 * number2;
				break;
			case "/":
				result = Math.floor(number1 / number2);
				break;
	}
}
var number1 = 0;
var number2 = 0;
var operation = "+";
var result;
var currentNumber = 0;
var screen = document.getElementById("table__thead__screen");
var pow = document.getElementById("pow");
var sqrt = document.getElementById("sqrt");
var reset = document.getElementById("C");
var equals = document.getElementById("equalsButton");
var numbers = document.querySelectorAll(".numberButton");
var operands = document.querySelectorAll(".operands");

for(var i = 0; i < numbers.length; i++) {
	numbers[i].addEventListener("click", function() {
		if (operation === "="){
			currentNumber = 0;
			operation = "+";
		}
		if(currentNumber == 0) {
			currentNumber = this.value;
		} else
			currentNumber += this.value;
		screen.innerHTML = currentNumber;
	});
}
for (var i = 0; i < operands.length; i++) {
	operands[i].addEventListener("click", function() {
		if (currentNumber == 0) {
			operation = this.value;
			screen.innerHTML = this.value;
		} else if (number1 === 0) {
			number1 = parseInt(currentNumber);
			operation = this.value;
			currentNumber = 0;
			screen.innerHTML = this.value;
		} else {
			number2 = parseInt(currentNumber);
			addToNumber();
			number1 = result;
			operation = this.value;
			currentNumber = 0;
			screen.innerHTML = this.value;
		}
	});
}
pow.addEventListener("click", function() {
	if (currentNumber == 0) {
		currentNumber = 0;
	} else {		
		screen.innerHTML = Math.pow(currentNumber, 2);
		currentNumber = Math.pow(currentNumber, 2);
	}
});
sqrt.addEventListener("click", function() {
	if (currentNumber == 0) {
		currentNumber = 0;
	} else {		
		screen.innerHTML = Math.sqrt(currentNumber);
		currentNumber = Math.sqrt(currentNumber);
	}
});
equals.addEventListener("click", function() {
	if (currentNumber == 0) {
		currentNumber = 0;
	} else if (number1 === 0) {
		currentNumber = 0;
	} else {
		number2 = parseInt(currentNumber);
		addToNumber();
		screen.innerHTML = result;
		number1 = 0;
		number2 = 0;
		currentNumber = result;
		operation = "=";
		result = 0;
	}
});
reset.addEventListener("click", function() {
	number1 = 0;
	number2 = 0;
	currentNumber = 0;
	result = 0;
	screen.innerHTML = 0;
});
document.onkeyup = function(event){
	var key = event.key;
	if (!isNaN(key)) {
		if (operation === "="){
			currentNumber = 0;
			operation = "+";
		}
			if (currentNumber == 0) {
				currentNumber = key;
			} else
				currentNumber += key;
			screen.innerHTML = currentNumber;
	}
	if (key === "+" || key === "-" || key === "*" || key === "/") {
		if (currentNumber == 0) {
			operation = key;
			screen.innerHTML = key;
		} else if (number1 === 0) {
			number1 = parseInt(currentNumber);
			operation = key;
			currentNumber = 0;
			screen.innerHTML = key;
		} else {
			number2 = parseInt(currentNumber);
			addToNumber();
			number1 = result;
			operation = key;
			currentNumber = 0;
			screen.innerHTML = key;
		}
	}
	if (key === "w") {
		if (currentNumber == 0) {
			currentNumber = 0;
		} else {		
			screen.innerHTML = Math.pow(currentNumber, 2);
			currentNumber = Math.pow(currentNumber, 2);
		}
	}
	if (key === "q") {
		if (currentNumber == 0) {
			currentNumber = 0;
		} else {		
			screen.innerHTML = Math.sqrt(currentNumber);
			currentNumber = Math.sqrt(currentNumber);
		}
	}
	if (key === "=" || key === "Enter") {
		if (currentNumber == 0) {
			currentNumber = 0;
		} else if (number1 === 0) {
			currentNumber = 0;
		} else {
			number2 = parseInt(currentNumber);
			addToNumber();
			screen.innerHTML = result;
			number1 = 0;
			number2 = 0;
			currentNumber = result;
			operation = "=";
			result = 0;
		}
	}
	if (key === "Escape" || key === "Backspace") {
		number1 = 0;
		number2 = 0;
		currentNumber = 0;
		result = 0;
		screen.innerHTML = 0;
	}
}