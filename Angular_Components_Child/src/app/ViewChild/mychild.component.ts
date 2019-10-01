import { Component, ContentChild, ElementRef } from '@angular/core';

@Component({
    selector: 'mychild-component',
    template: `
        <div>
        	<h4>{{mychildText}}</h4>
        	<p>
        		<button (click)="localClick()">TEST</button>
        	</p>
        </div>`,
    styles: [`
        div {
            border: 2px solid green;
        }`]
})
export class MyChildComponent {

    mychildText: string = '= mychild-component =';

    childFuncForParent() {
        alert(this.mychildText);
    }

    // CONTENT-CHILD - to ...

    @ContentChild('parentToChildBind', { static: false }) parentVarForChild: ElementRef;

    localClick() {
        this.parentVarForChild['mychildText'] = 'NEW TEXT';
    }
}