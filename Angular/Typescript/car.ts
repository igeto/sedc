class Car {
    private _numberOfWheels: number;
    constructor(public make: string, public model: string){}

    get numberOfWheels () {
        return this._numberOfWheels;
    }
    set numberOfWheels (wheelCount) {
        this._numberOfWheels = wheelCount;
    }
    setNumberOfWheels(wheels) {
        this._numberOfWheels = wheels;
    }
}

let myCar = new Car("BMW", "320d");
myCar.setNumberOfWheels(4);
console.log(myCar);
