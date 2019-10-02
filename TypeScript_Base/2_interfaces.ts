{
    interface Rect {
        readonly id: string
        color?: string
        size: {
            height: number
            width: number
        }
    }

    const MyRect1: Rect = {
        id: '1234',
        size: {
            height: 10,
            width: 20
        }
    }

    const MyRect2 = {} as Rect
    MyRect2.color = 'black'

    // INTERFACES INHERITANCE :

    interface RectWithArea extends Rect {
        getArea: () => number
    }

    const MyRect3: RectWithArea = {
        id: '12345',
        size: { height: 20, width: 30 },
        getArea(): number {
            return this.size.height * this.size.width;
        }
    }

    console.log(MyRect3.getArea())

    // INTERFACE FOR MANY IDENTICAL FIELDS :

    interface IStyles {
        [key: string]: string
        // border: string, 
        // ... - in such way we MUST to define ALL fields that must be ASSIGNED in derived
    }

    const myCss: IStyles = {
        border: '1px solid black',
        borderRadius: '10px',
        MarginTop: '2px'
        // ...
    }
}