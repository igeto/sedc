var Car = /** @class */ (function () {
    function Car(make, model) {
        this.make = make;
        this.model = model;
    }
    Object.defineProperty(Car.prototype, "numberOfWheels", {
        get: function () {
            return this._numberOfWheels;
        },
        set: function (wheelCount) {
            this._numberOfWheels = wheelCount;
        },
        enumerable: true,
        configurable: true
    });
    Car.prototype.setNumberOfWheels = function (wheels) {
        this._numberOfWheels = wheels;
    };
    return Car;
}());
var myCar = new Car("BMW", "320d");
myCar.setNumberOfWheels(4);
console.log(myCar);
