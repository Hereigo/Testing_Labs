//
let dataUser = { name: "Robin" };

function newUser(dataUser) {

    // LET dataUser is in LOCAL scope !
    dataUser = { name: "Kate" };

    console.log(dataUser.name); // Kate
}

newUser(dataUser);

console.log(dataUser.name); // Robin