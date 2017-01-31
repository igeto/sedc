class Person {
	constructor(name, lastName, yearOfBirth, job) {
		this.name = name;
		this.lastName = lastName;
		this.yearOfBirth = yearOfBirth;
		this.job = job;
	}
	calculateAge() {
		return new Date().getFullYear() - this.yearOfBirth;
	}
}

class Student extends Person {
	constructor(name, lastName, yearOfBirth, subjects) {
		super(name, lastName, yearOfBirth, "student");
		this.subjects = subjects || [];
	}
	intro() {
		return `I am ${this.name} and I am ${super.calculateAge()} years old`;
	}
}

let igeto = new Student("Igor", "Mitkovski", "1988");
let john = new Person("John", "Doe", "1990", "developer");

// let developer = Object.create(person, knownLanguages)

let a = 3;
let b = 2;

function TheatreSeats() {
	let _seats = [];

	this.placePaerson = function(person) {
		_seats.push(person);
	}
}

function Persona(name, age, job) {
	let _email = "";
	this.name = name;
	this.age = age;
	this.job = job;
	this.setEmail = function(email) {
		//name@email.com - example
		let regEx = /[a-z0-9\.\-_]+@[a-z0-9]+\.[a-z]{2,3}$/;
		if(regEx.test(email)) {
			_email = email;
		} else {
			throw new Error("Not valid email address");
		}
	}
	this.getEmail = function() {
		return _email;
	}
}

Persona.prototype.intro = function() {
	return `My name is ${this.name}. I am ${this.age} years old.
	I work as ${this.job}. My email address is `;
}

let jonce = new Persona("Jonce Krsikoski", 30, "developer");
jonce.setEmail("igeto@gmail.com");
