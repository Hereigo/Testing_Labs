import { Component, ElementRef, ViewChild } from '@angular/core';
import { MyChildComponent } from './mychild.component';

// TEMPLATE #VARIABLES & @VIEW_CHILD DIRECTIVES :

@Component({
    selector: 'my-app',
    template: `
        <p>
        	<mychild-component #mychildRef></mychild-component>
        	<button (click)=mychildRef.childClick()>Button 1</button>
        </p>
        <p>
        	<button (click)=localClick()>Button 2</button>
        </p>
        <p>
        	<button (click)=parentClick()>Button 3</button>
        </p>`
})
export class AppComponent {

    @ViewChild("mychildRef", { static: false }) private myChElemRef: ElementRef;

    localClick() {
        this.myChElemRef['mychildText'] = this.myChElemRef['mychildText'].toUpperCase();
    };

    @ViewChild(MyChildComponent, { static: false }) private myChCompoBind: MyChildComponent;

    parentClick() {
        this.myChCompoBind.childClick()
    };
}