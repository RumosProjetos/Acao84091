function Sample() {
    return "Sample";
}
function addNumbers(x, y) {
    return x + y;
}
console.log(addNumbers(3, 6));
function playground() {
    var x = 3;
    var y = 6;
    var z = addNumbers(x, y);
    console.log(z);
}
function playground2() {
    var firstName = "Mateo";
    var sentence = "My name is ${firstName}. I am new to TypeScript.";
    console.log(sentence);
}
var ContractStatus;
(function (ContractStatus) {
    ContractStatus[ContractStatus["Permanent"] = 0] = "Permanent";
    ContractStatus[ContractStatus["Temporary"] = 1] = "Temporary";
    ContractStatus[ContractStatus["Apprentice"] = 2] = "Apprentice";
})(ContractStatus || (ContractStatus = {}));
var employeeStatus = ContractStatus.Apprentice;
console.log(employeeStatus);
var randomValue = 10;
randomValue = "Mateo";
console.log(randomValue.toupperCase());
randomValue = true;
console.log(randomValue.toUpperCase());
var randomValue2 = 10;
randomValue2 = true;
randomValue2 = 'Mateo';
if (typeof randomValue2 === "string") {
    console.log(randomValue2.toUpperCase()); //* Returns MATEO to the console.
}
else {
    console.log("Error - A string was expected here."); //* Returns an error message.
}
var multiType;
multiType = 20;
multiType = true;
// multiType = "Mateo";    //* Returns an error message.
function add(x, y) {
    if (typeof x === 'number' && typeof y === 'number') {
        return x + y;
    }
    if (typeof x === 'string' && typeof y === 'string') {
        return x.concat(y);
    }
    throw new Error('Parameters must be numbers or strings');
}
console.log(add('one', 'two')); //* Returns "onetwo"
console.log(add(1, 2)); //* Returns 3
console.log(add('one', 2)); //* Returns error
var newManager = {
    employeeId: 1,
    age: 25,
    stockPlan: true
};
var myResult = "pass";
myResult = "fail";
//myResult = "inconclusive";    //* Returns an error message.
//# sourceMappingURL=sample.js.map