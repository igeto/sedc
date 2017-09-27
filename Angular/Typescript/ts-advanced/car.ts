export class Car {
    private _numberOfWheels: number;
    constructor(public make: string, public model: string){}

    setNumberOfWheels(wheels) {
        this._numberOfWheels = wheels;
    }
    drive() {
        this._numberOfWheels ? 
        console.log("brm brm brm") : 
        console.log("Your car doesnt have wheels yet");
    }
}
