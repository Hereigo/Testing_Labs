import { Component, ElementRef, ViewChild } from '@angular/core';
import { MyChildComponent } from './mychild.component';
import { strict } from 'assert';

@Component({
    selector: 'my-app',
    template: `
        <div>
        	<mychild-component #mychildRef></mychild-component>
        </div>
        <p>
        	<button (click)=mychildRef.click_onChild()>Child.</button>
        </p>
        <p>
        	<button (click)=click_onParent()>Parent.</button>
        </p>
        <p>
        	<button (click)=click_onParent2()>Parent 2</button>
        </p>`,
    styles: [`
        div {
            border: 2px solid orange;
            padding 10px
        }`]
})
export class AppComponent {

    @ViewChild(MyChildComponent, { static: false }) 
    private myChCompoBind: MyChildComponent;

    click_onParent() { this.myChCompoBind.click_onChild() };

    @ViewChild("mychildRef", { static: false })
    myChElemRef: ElementRef;

    click_onParent2() { 
        const textBefore:string = this.myChElemRef['test'];
        const textAfter:string = textBefore.toUpperCase();
        this.myChElemRef['test'] = textAfter; // NOT ALLOWED IN A STRICT MODE ...
    }
}