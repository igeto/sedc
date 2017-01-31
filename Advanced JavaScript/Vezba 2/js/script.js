let numbers = [1, 3, 5, 2, 6, 9, 12, 5, 16, 7];

let arrayOfNumbers = function (array, condition) {
    let result = [];
    for (let i = 0; i < array.length; i++) {
       let item = array[i];
       if(condition(item))
        result.push(item);
    }
    return result;
}

//let reutrnOddNumbers = arrayOfNumbers(numbers, x => x % 2 != 0);

console.log(arrayOfNumbers(numbers, x => (x % 2 !== 0)));
console.log(arrayOfNumbers(numbers, x => (x % 2 === 0)));
console.log(arrayOfNumbers(numbers, x => (x > 5 && x < 10)));
console.log(arrayOfNumbers(numbers, x => (x % 3 === 0)));
console.log(arrayOfNumbers(numbers, x => (x % 5 === 0)));
console.log(arrayOfNumbers(numbers, x => {
    let sqrt = Math.sqrt(x);
    let isqrt = Math.sqrt(x) | 0;
    return sqrt === isqrt;
}));


// let oddNumbers = numbers.filter((x) => x % 2 != 0);
// console.log(oddNumbers);

// let evenNumbers = numbers.filter(x => x % 2 == 0);
// console.log(evenNumbers);