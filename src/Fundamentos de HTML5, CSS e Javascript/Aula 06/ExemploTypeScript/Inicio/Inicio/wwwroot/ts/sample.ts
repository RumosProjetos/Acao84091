function Sample() {
    return "Sample";
}


function addNumbers(x: number, y: number) {
    return x + y;
}
console.log(addNumbers(3, 6));

function playground() {
    let x: number = 3;
    let y: number = 6;
    let z: number = addNumbers(x, y);

    console.log(z);
}


function playground2() {
    let firstName: string = "Mateo";
    let sentence: string = "My name is ${firstName}. I am new to TypeScript.";

    console.log(sentence);
}

enum ContractStatus {
    Permanent,
    Temporary,
    Apprentice
}

let employeeStatus: ContractStatus = ContractStatus.Apprentice;
console.log(employeeStatus);

let randomValue: any = 10;
randomValue = "Mateo";

console.log(randomValue.toupperCase());
randomValue = true;


console.log((randomValue as string).toUpperCase());


let randomValue2: unknown = 10;

randomValue2 = true;
randomValue2 = 'Mateo';

if (typeof randomValue2 === "string") {
    console.log((randomValue2 as string).toUpperCase());    //* Returns MATEO to the console.
} else {
    console.log("Error - A string was expected here.");    //* Returns an error message.
}


let multiType: number | boolean;
multiType = 20;
multiType = true;
// multiType = "Mateo";    //* Returns an error message.


function add(x: number | string, y: number | string) {
    if (typeof x === 'number' && typeof y === 'number') {
        return x + y;
    }
    if (typeof x === 'string' && typeof y === 'string') {
        return x.concat(y);
    }
    throw new Error('Parameters must be numbers or strings');
}
console.log(add('one', 'two'));  //* Returns "onetwo"
console.log(add(1, 2));          //* Returns 3
console.log(add('one', 2));      //* Returns error



interface Employee {
    employeeId: number;
    age: number;
}

interface Manager {
    stockPlan: boolean;
}

type ManagementEmployee = Employee & Manager;
let newManager: ManagementEmployee = {
    employeeId: 1,
    age: 25,
    stockPlan: true
}



type testResult = "pass" | "fail" | "incomplete";
let myResult: testResult = "pass";
myResult = "fail";
//myResult = "inconclusive";    //* Returns an error message.



