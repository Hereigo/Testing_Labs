{
    var oneKeyOf = '_id';
    oneKeyOf = 'age';
    oneKeyOf = 'created';
    console.log(oneKeyOf.toUpperCase()); // CREATED
    // typeof OBJECT like derived TYPE but with Piked values only
    var userNoDateId = 'age';
    // userNoDateId = '_id' - Error - Not allowed!
    var userWithName = {
        _id: 123,
        name: 'Felix'
    };
    console.log(typeof (userNoDateId)); // STRING !
    console.log(typeof (userWithName)); // OBJECT !
}
