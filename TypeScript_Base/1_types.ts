{
    const numberArray1: number[] = [1, 1, 2, 3, 5, 8, 13]
    const numberArray2: Array<number> = [1, 1, 2, 3, 5, 8, 13]
    const stringArray1: string[] = ['one', 'two', 'three']

    function reverseAnyArray<T>(arr: T[]): T[] {
        return arr.reverse()
    }

    console.log(reverseAnyArray(numberArray2))
    console.log(reverseAnyArray(stringArray1))

    const myTuple: [string, number] = ['Alex', 12345]

    // ANY is let - but NOT const !

    let myAnyVariable: any = 42
    myAnyVariable = 'test'
    myAnyVariable = true

    // NEVER - is for ERROR blocks or for ENDLESS functions :

    function throwMyError(message: string): never {
        throw new Error(message);
    }

    function endlessLoop(): never {
        while (true) { }
    }

    // CUSTOM TYPES :

    type MyString = string
    const abc: MyString = "abcdef"

    type ID = number | string
    const a: ID = 123
    const b: ID = 'abcde'
    // const c : ID = true - error

    type specific = string | null | undefined
}