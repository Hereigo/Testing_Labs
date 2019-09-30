import { Component, ContentChild, ElementRef } from '@angular/core';

@Component({
    selector: 'child-comp-place',
    template: `
        <div id='ng-cont'>
        	<p>
        		<strong>&lt; ng-content &gt;</strong> - inside of CHILD let us to get PARENT data.
        	</p>
        	<ng-content></ng-content>
        </div>
        <br>
        	<button (click)="change()">Update &lt;child-component #bindParent&gt; by @ContentChild('bindParent'...</button>`,
    styles: [`
        #ng-cont {
            border: 2px solid blue
        }`]
})
export class ChildComponent {

    @ContentChild("bindParent", { static: false }) contentCh2BindParent: ElementRef;

    childLocalVar: string = "CHILD local var!!!";

    change() {
        this.contentCh2BindParent.nativeElement.textContent = this.childLocalVar;
    }
}