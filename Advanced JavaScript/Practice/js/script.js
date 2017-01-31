// let emp1 = {};

// emp1.firstName = "Michael";
// emp1.lastName = "Scott";
// emp1.gender = "m";
// emp1.designation = "Regional Manager";

function CreateEmplyeeObject(firstName, lastName, gender, designation) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.gender = gender;
    this.designation = designation;
}

// let emp3 = new CreateEmplyeeObject("Jim", "Halpert", "m", "Sales Representative");

let bicycle1 = CreateBicycle(50, 20, 4);
let bicycle2 = CreateBicycle(20, 5, 1);

function CreateBicycle(cadence, speed, gear) {
    let newBicycle = {};

    newBicycle.cadence = cadence;
    newBicycle.speed = speed;
    newBicycle.gear = gear;
    return newBicycle;
}

let bicycle3 = new Bicycle(50, 20, 4);

function foo() {
    console.log("Hello");
    console.log(this);
}

foo(); // Method #1

let Obj = { prop: "asdasd" };

Obj.foo = function() {
    console.log("Hello");
    console.log(this);
}

Obj.foo(); // Method #2

new foo(); //Method #3

function Bicycle(cadence, speed, gear,
    tirePressure) {
    this.cadence = cadence;
    this.speed = speed;
    this.gear = gear;
    this.tirePressure = tirePressure;
    this.inflateTires = function() {
        this.tirePressure += 3;
    }
}

bicycle1 = new Bicycle(50, 20, 4, 25);

function Mechanic(name) {
    this.name = name;
}

let mike = new Mechanic("Mike");
mike.inflateTires = bicycle1.inflateTires;
mike.inflateTires.call(bicycle1); // doesnt work

function Employee(name) {
    this.name = name;
}
Employee.prototype.getName = function() {
    return this.name;
};
var emp1 = new Employee("Jim");
var emp2 = new Employee("Pam");

Employee.prototype.playPranks = function() {
    console.log("Prank played");
};

var emp3 = new Employee("Dwight");

function Manager(name, dept) {
    this.name = name;
    this.dept = dept;
}
Manager.prototype.getDept = function() {
    return this.dept;
};

let mgr = new Manager("Michael", "Sales");

mgr.__proto__.__proto__ = Employee.prototype;
