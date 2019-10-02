{
    var numberArray1 = [1, 1, 2, 3, 5, 8, 13];
    var numberArray2 = [1, 1, 2, 3, 5, 8, 13];
    var stringArray1 = ['one', 'two', 'three'];
    function reverseAnyArray(arr) {
        return arr.reverse();
    }
    console.log(reverseAnyArray(numberArray2));
    console.log(reverseAnyArray(stringArray1));
    var myTuple = ['Alex', 12345];
    // ANY is let - but NOT const !
    var myAnyVariable = 42;
    myAnyVariable = 'test';
    myAnyVariable = true;
    // NEVER - is for ERROR blocks or for ENDLESS functions :
    function throwMyError(message) {
        throw new Error(message);
    }
    function endlessLoop() {
        while (true) { }
    }
    var abc = "abcdef";
    var a = 123;
    var b = 'abcde';
}
