class Person {
    constructor (public firstName: string, public lastName: string) {}

    public getFullName = () => `${this.firstName} ${this.lastName}`;
}

let igor = new Person("Igor", "Mitkovski");

console.log(igor.getFullName());