function numberToWords(number){
    
    if (typeof number !== "number")
        throw "Only works for numbers";
    
    var digits = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
    var tensNames =["", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
    var teens =["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
    
    if (getLength(number) < 2)
        return digits[number];

    if (number < 20)
        return teens[number - 10];
    
    if (getLength(number) < 3) {
        var units = digits[number % 10];
        var tens = tensNames[Math.floor(number / 10)];

        if (units === "zero") {
            return tens;
        } else {
            return tens + " " + units;
        }
    }

    if (getLength(number) < 4) {
        var lastTwo = numberToWords(number % 100);
        var hundreds = digits[Math.floor(number / 100)];
        
        if (lastTwo === "zero") {
            return hundreds +" hundred";
        } else {
            return hundreds +" hundred " + lastTwo;
        }
    }
    if (getLength(number) < 7) {
        var lastThree = numberToWords(number % 1000);
        
        var thousands = numberToWords(Math.floor(number / 1000));

        if (lastThree === "zero") {
            return thousands +" thousand";
        } else {
            return thousands +" thousand " + lastThree;
        }
    }
}

function getLength(number) {
    return number.toString().length;
  }