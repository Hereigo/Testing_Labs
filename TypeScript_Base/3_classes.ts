{
    class Car {
        readonly numberOfWheels: number
        // readonly modelName: string
        constructor(readonly modelName: string) { // 'readonly' MUST HAVE to create PROPERTY!
            // this.modelName = modelName
            // this.modelName - can be created as class-field by compiler!
        }
    }

    const myCar = new Car('Toyota Corolla');

    console.log(myCar.modelName)

    class myCar2 extends Car { }
    // myCar2.modelName = 'myCar2 doesn't contains modelName property!'

    // ABSTRACT CLASSES :

    abstract class AComponent {
        abstract render(): void
        abstract info(): string
    }

    class AppComponent extends AComponent {
        render(): void {
            console.log('Component rendering...')
        }
        info(): string {
            return 'Hello!'
        }
    }

    // const myAppComponent = {} as AppComponent - create obj of selected type - but UNDEFINED!
    const myAppComponent = new AppComponent()

    myAppComponent.render()
    console.log(myAppComponent.info())

}