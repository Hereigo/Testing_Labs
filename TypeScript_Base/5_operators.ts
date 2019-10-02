{
    interface User {
        _id: number
        name: string
        age: number
        created: Date
    }

    // KEY_OF :

    type UserKeyOfProps = keyof User // '_id' | 'name | 'age' | 

    let oneKeyOf: UserKeyOfProps = '_id'
    oneKeyOf = 'age'
    oneKeyOf = 'created'

    console.log(oneKeyOf.toUpperCase()) // CREATED

    // KEY_OF - EXCLUDE or PICK :

    // typeof STRING (with allowed values but Excluded this values)
    type UserWithNoDateNoId = Exclude<keyof User, '_id' | 'created'>
    type UserWithNameOnly = Pick<User, '_id' | 'name'>
    // typeof OBJECT like derived TYPE but with Piked values only

    const userNoDateId: UserWithNoDateNoId = 'age'
    // userNoDateId = '_id' - Error - Not allowed!

    const userWithName: UserWithNameOnly = {
        _id: 123,
        name: 'Felix'
    }

    console.log(typeof (userNoDateId)) // STRING !
    console.log(typeof (userWithName)) // OBJECT !
}