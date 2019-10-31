// FACTORIAL == 1 * 2 * 3 * ... * N

function factorial(n) {

    if (n == 1) {
        return 1;
    } else {
        return factorial(n - 1) * n;
    }
}

console.log(factorial(5));


// 1 + 1 + 2 + 3 + 5 + 8 + 13 + 21 + ...

function fibonacci(n) {

    if (n <= 1) {
        return n;
    } else {
        return fibonacci(n - 2) + fibonacci(n - 1);
    }
}

console.log(fibonacci(7));