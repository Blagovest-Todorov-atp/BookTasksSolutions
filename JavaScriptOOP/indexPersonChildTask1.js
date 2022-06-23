class Person {

    constructor(age, name) {
        this.age = age;   // .age -> is the setter age
        this.name = name;   // .name is the setter name
    }

    get age() {
        return this._age;
    }

    set age(ageX) {
        if (ageX < 0) {
            throw new Error("Age cannot be negative");
        }
        this._age = ageX;   // _age is the field age !!!
    }

    get name() {
        return this._name;
    }

    set name(nameX) {
        this._name = nameX;  // _name -> is the field name !!! 
    }
}

class Child extends Person {    

    constructor(age, name) {
        super(age, name);
    }

    set age(ageX) {
        if (ageX > 15) {
            throw new Error("Not a child");
        }

        super.age = ageX;
    }
}

let child = new Child(15, "Viki");
console.log(`${child._name},${child._age}`);


let person = new Person(50, "Tony");
console.log(`${person._name}, ${person._age}`);

// Error is a class in JS   ;  new Error("error message");  !!! index.js is the entry file just like in  C# is the input file program.cs with the Main Method !!!
