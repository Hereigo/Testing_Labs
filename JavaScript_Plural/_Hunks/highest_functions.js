
// Array.filter( hi-func )

isEven = (num) => num % 2 === 0;

result = [1, 2, 3, 4, 5].filter(isEven);

console.log(result); // [2, 4]

// USING FILTER (2)

let usersArr = [{ name: 'Alex', age: 10 }, { name: 'Max', age: 20 }, { name: 'Hanna', age: 30 }, { name: 'Felix', age: 40 }];

endsWithX = (string) => string.toLowerCase().endsWith('x');

namesEndedWithX = usersArr.filter((user) => endsWithX(user.name));

console.log(namesEndedWithX); // 3 objects with names: Alex, Max, Felix

// === USING MAP : ===

getUserName = (user) => user.name;

usernames = usersArr.map(getUserName);

console.log(usernames); // ['Alex', 'Max', 'Hanna', 'Felix' 

// === USING REDUCE (Accumulator) : ===

totalUsersAge = usersArr.reduce((accumulator, currentVal) => currentVal.age + accumulator, 0);

// total = 0;
// for (let i = 0; i < users.length; i++) {
//   total += users[i].age;
// }
console.log(totalUsersAge);
