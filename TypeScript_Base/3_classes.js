var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
{
    var Car = /** @class */ (function () {
        // readonly modelName: string
        function Car(modelName) {
            this.modelName = modelName;
            // this.modelName = modelName
            // this.modelName - can be created as class-field by compiler!
        }
        return Car;
    }());
    var myCar = new Car('Toyota Corolla');
    console.log(myCar.modelName);
    var myCar2 = /** @class */ (function (_super) {
        __extends(myCar2, _super);
        function myCar2() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        return myCar2;
    }(Car));
    // myCar2.modelName = 'myCar2 doesn't contains modelName property!'
    // ABSTRACT CLASSES :
    var AComponent = /** @class */ (function () {
        function AComponent() {
        }
        return AComponent;
    }());
    var AppComponent = /** @class */ (function (_super) {
        __extends(AppComponent, _super);
        function AppComponent() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        AppComponent.prototype.render = function () {
            console.log('Component rendering...');
        };
        AppComponent.prototype.info = function () {
            return 'Hello!';
        };
        return AppComponent;
    }(AComponent));
    // const myAppComponent = {} as AppComponent - create obj of selected type - but UNDEFINED!
    var myAppComponent = new AppComponent();
    myAppComponent.render();
    console.log(myAppComponent.info());
}
