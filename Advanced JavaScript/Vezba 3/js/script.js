//Objects

// let john = {

// }

// john.name = "John";
// john.lastName = "Doe";
// john.fullName = function () {
// 	return `${this.name} ${this.lastName}`;
// }

// console.log(john);

// let jane = {
// 	name: "Jane",
// 	lastName: "Doe",
// 	fullName: function () {
// 		return `${this.name} ${this.lastName}`; //ES6 madafakaaaaaaa
// 	}
// }

// //Constructor Notation

// function Person(name, lastName, yearOfBirth, sex) {
// 	this.name = name;
// 	this.lastName = lastName;
// 	this.yearOfBirth = yearOfBirth;
// 	this.age = parseInt(this.calculateAge());
// 	this.sex = sex;
// 	this.fullName = function () {
// 		return `${this.name} ${this.lastName}`; //ES6 madafakaaaaaaa
// 	}
// }
// Person.prototype.calculateAge = function() {
// 	return new Date().getFullYear() - this.yearOfBirth;
// }

// let marko = new Person("Marko", "Markovic", "01.01.1903", "yes");

//ES2015 CLASSES

class Person {
	constructor(name, lastName, yearOfBirth, sex) {
		this.name = name;
		this.lastName = lastName;
		this.yearOfBirth = yearOfBirth;
		this.sex = sex;
	}
	fullName() {
		return `${this.name} ${this.lastName}`;
	}
	calculateAge() {
		return new Date().getFullYear() - this.yearOfBirth;
	}
}

// class Lawyer extends Person{
// 	constructor() {
// 		super();
// 	}
	
// 	defendsPeope(){

// 	}	
// }
// let igeto = new Lawyer("Igor", "igeto")
var john = new Person("John", "Malkovic", 1980, "yes");

Array.prototype.getLast = function() {
	return this[this.length - 1];
}

let niza = [1, 2, 3];

// function getLast(n) {
// 	return n[n.length -1];
// }

function Book(title, author, genre, isbn, price) {
	this.title = title;
	this.author = author;
	this.genre = genre;
	this.isbn = isbn;
	this.price = price;
}
Book.prototype.getPrice = function() {
	return this.price;
}

function ComicBook(title, author, isbn, price, additionalPrice) {
	Book.call(this, title, author, "comic", isbn, price);
	this.additionalPrice = additionalPrice;
}
ComicBook.prototype = new Book();//Object.create(Book.prototype);
ComicBook.prototype.intro = function() {
	return `Book ${this.title} by ${this.author}`;
}

ComicBook.prototype.getPrice = function() {
	return this.price + this.additionalPrice;
}
let IronMan = new ComicBook("marvel universe", "John", 65461316546, 100, 20);

function FictionBook(title, author, isbn, price, additionalPrice) {
	let arg = [];
	for (var i = 0; i < arguments.length; i++) {
		arg[i] = arguments[i];
	}
	arg.splice(2, 0, "fiction");
	Book.apply(this, arg);
}
FictionBook.prototype = new Book;

let book2 = new FictionBook("The Return of Thе Жарн", "Emilija", "666", 100, 20);
