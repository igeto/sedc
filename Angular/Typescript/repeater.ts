//make a function that will repeat a given string a given number of times
// e.g. repeat("weko", 3) should return "wekowekoweko"


let repeat = (input:string, multiplier: number): string => {
    return input.repeat(multiplier);
}

console.log(repeat("Igor", 4));