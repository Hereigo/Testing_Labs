import { Component, ElementRef, ViewChild } from '@angular/core';
import { MyChildComponent } from './mychild.component';

// TEMPLATE #VARIABLES & @VIEW_CHILD DIRECTIVES :

@Component({
    selector: 'my-app',
    template: `
        <p>
        	<mychild-component #parentToChildBind></mychild-component>
        </p>
        <p>
        	<button (click)=parentToChildBind.childFuncForParent()>Button 1</button>
        </p>
        <p>
        	<button (click)=localClick()>Button 2</button>
        </p>
        <p>
        	<button (click)=parentClick()>Button 3</button>
        </p>`
})
export class AppComponent {

    @ViewChild("parentToChildBind", { static: false }) private P2ChB_ElemRef: ElementRef;

    localClick() {
        this.P2ChB_ElemRef['mychildText'] = this.P2ChB_ElemRef['mychildText'].toUpperCase();
    };

    @ViewChild(MyChildComponent, { static: false }) private myChCompoBind: MyChildComponent;

    parentClick() {
        this.myChCompoBind.childFuncForParent()
    };
}