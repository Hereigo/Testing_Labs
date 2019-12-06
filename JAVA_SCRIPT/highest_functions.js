
// Array.filter( hi-func )

isEven = (num) => num % 2 === 0;

result = [1, 2, 3, 4, 5].filter(isEven);

console.log(result); // [2, 4]

// Using FILTER (2)

let usersArr = [{ name: 'Alex', age: 10 }, { name: 'Max', age: 20 }, { name: 'Hanna', age: 30 }, { name: 'Felix', age: 40 }];

endsWithX = (string) => string.toLowerCase().endsWith('x');

namesEndedWithX = usersArr.filter((user) => endsWithX(user.name));

console.log(namesEndedWithX); // 3 objects with names: Alex, Max, Felix

// === Using MAP : ===

getUserName = (user) => user.name;

usernames = usersArr.map(getUserName);

console.log(usernames); // ['Alex', 'Max', 'Hanna', 'Felix' 

// === Using REDUCE (Accumulate) : ===

totalUsersAge = usersArr.reduce((totalAge, currentVal) => currentVal.age + totalAge, 0);
// totalAge = 0;
// for (let i = 0; i < users.length; i++) {
//   totalAge += users[i].age;
// }
console.log("total Users Age = " + totalUsersAge);

function sum(...args) {
    return args.reduce((a, b) => a + b, 0);
}
console.log(sum(2, 3, 4, 5, 6)); // 20