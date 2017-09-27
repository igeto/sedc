export class Person {
    constructor (public firstName: string, public lastName: string) {counter++;}
    
    public getFullName = () => `${this.firstName} ${this.lastName}`;
}


export var counter = 0;
