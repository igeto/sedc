"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class Person {
    constructor(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.getFullName = () => `${this.firstName} ${this.lastName}`;
    }
}
exports.Person = Person;
