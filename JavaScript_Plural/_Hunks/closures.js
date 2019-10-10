
console.log(" === CLOSURES : (capturing execution context of function's local var)");

function getCounter() {

  var counter = 0;

  return function () {
    return counter++;
  }
}

var getCounterStore = getCounter();

console.log(getCounterStore());  // 0
console.log(getCounterStore());  // 1
console.log(getCounterStore());  // 2