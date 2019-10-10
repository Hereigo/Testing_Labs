import '../styles/index.scss';

console.log(' = = =  LET : INSIDE OF FUNCTION : = = =  ');

let overridenVar = "Hello 1";
let hasCloneInside = "Hello 2";

let FuncForLet = function() {

    let insideFunction = "Hello 3";

    console.log(overridenVar); // 'Hello 1'
    overridenVar = "Overriden Hello 1";

    console.log(hasCloneInside); // 'undefined' - defined below!
    let hasCloneInside = "Overriden Hello 2 (with LET)";
};
FuncForLet();

console.log(overridenVar); // 'Overriden Hello 1'
console.log(hasCloneInside); // 'Hello 2'
// console.log(insideFunction); // ReferenceError: 'insideFunction' is not defined

console.log();
console.log(" = = =  IIFE (Immediately Invoked Func. Expr.) : = = =  ");

var card;

let iife = (function() {
    card = 123;
    console.log('IIFE running!');
    return {};
})();

console.log(card); // 123

console.log();
console.log(" = = = = CLOSURES : = = = = ");

let app = (function() {

    let id = 12345;
    let getId = function() {
        return id;
    };
    // (app.property): (value) function() => number
    return { getId: getId };
    // return { getId }; - is the same.
})();

console.log(app.getId());