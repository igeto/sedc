function magicalWell (number1, number2, number3) {
	sumOfCoins = 0;
	for (var i = 0; i < number3; i++) {
		sumOfCoins += number1 * number2;
		number1++;
		number2++;
	}
	return sumOfCoins;
}

var coins = parseInt (prompt ("Enter the value of received coins"));
var multiplier = parseInt (prompt ("Enter the prize multiplier"));
var marbles = parseInt (prompt ("Enter the number of marbles"));

document.write ("You have "+marbles+" tries <br />");

var outcome = magicalWell (coins, multiplier, marbles);

document.write ("You erned "+outcome+" coins");