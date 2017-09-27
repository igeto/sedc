class Car {
    constructor(make, model) {
        this.make = make;
        this.model = model;
    }
    get numberOfWheels() {
        return this._numberOfWheels;
    }
    set numberOfWheels(wheelCount) {
        this._numberOfWheels = wheelCount;
    }
    setNumberOfWheels(wheels) {
        this._numberOfWheels = wheels;
    }
}
let myCar = new Car("BMW", "320d");
myCar.setNumberOfWheels(4);
console.log(myCar);
