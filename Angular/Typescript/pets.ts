let jsonFile = require('./data.json');

type size = "small" | "medium" | "large";

interface Pet {
    name: string;
    species: string;
    breed: string;
    size: size;
    age: number
}

let Pets : Pet[] = [];

for (var i = 0; i < jsonFile.pets.length; i++) {
    Pets.push(jsonFile.pets[i]);    
}

console.log(Pets.filter(pet => pet.species === "dog").length)
