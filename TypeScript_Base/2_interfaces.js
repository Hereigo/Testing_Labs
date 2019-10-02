{
    var MyRect1 = {
        id: '1234',
        size: {
            height: 10,
            width: 20
        }
    };
    var MyRect2 = {};
    MyRect2.color = 'black';
    var MyRect3 = {
        id: '12345',
        size: { height: 20, width: 30 },
        getArea: function () {
            return this.size.height * this.size.width;
        }
    };
    console.log(MyRect3.getArea());
    var myCss = {
        border: '1px solid black',
        borderRadius: '10px',
        MarginTop: '2px'
        // ...
    };
}
