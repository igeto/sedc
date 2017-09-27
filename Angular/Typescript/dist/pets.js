let jsonFile = require('./data.json');
let Pets = [];
for (var i = 0; i < jsonFile.pets.length; i++) {
    Pets.push(jsonFile.pets[i]);
}
console.log(Pets.filter(pet => pet.species === "dog").length);
