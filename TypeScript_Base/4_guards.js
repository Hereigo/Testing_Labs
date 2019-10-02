{
    // TYPE_OF :
    function toDblToUpper(x) {
        if (typeof x === 'number') {
            return (x * 2).toString();
        }
        else {
            return x.toUpperCase();
        }
    }
    // INCTANCE_OF :
    var ServerResponse = /** @class */ (function () {
        function ServerResponse() {
        }
        return ServerResponse;
    }());
    var ServerError_1 = /** @class */ (function () {
        function ServerError() {
        }
        return ServerError;
    }());
    function proccesResponse(res) {
        if (res instanceof ServerError_1) {
            console.log(res.header + ' - ' + res.errMessage);
        }
        else {
            console.log(res.header + ' - ' + typeof (res.response));
        }
    }
    var testResponse = new ServerResponse();
    testResponse.header = 'ok';
    testResponse.response = 12345;
    proccesResponse(testResponse);
    function setAlertType(type) { }
    setAlertType('danger');
    // setAlertType('undefined') - ERROR !!1
}
