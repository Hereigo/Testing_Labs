{
    // TYPE_OF :

    function toDblToUpper(x: string | number): string {
        if (typeof x === 'number') {
            return (x * 2).toString()
        }
        else {
            return x.toUpperCase()
        }
    }

    // INCTANCE_OF :

    class ServerResponse {
        header: string
        response: any
    }

    class ServerError {
        header: string
        errMessage: string
    }

    function proccesResponse(res: ServerResponse | ServerError) {
        if (res instanceof ServerError) {
            console.log(res.header + ' - ' + res.errMessage)
        } else {
            console.log(res.header + ' - ' + typeof (res.response))
        }
    }

    const testResponse = new ServerResponse()
    testResponse.header = 'ok'
    testResponse.response = 12345

    proccesResponse(testResponse)

    // ....L0

    type MyAlertType = 'success' | 'danger' | 'warning'

    function setAlertType(type: MyAlertType) { }

    setAlertType('danger')
    // setAlertType('undefined') - ERROR !!1



}
