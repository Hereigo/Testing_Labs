import { Component } from '@angular/core';

// Directive - [ngClass] takes - JS-OBJECT { js-class-name : bool (to activate class) }
// Directive - [ngStyle] takes - Plain CSS-STYLES.

@Component({
    selector: 'my-app',
    template: `
        <p>
        	<span [ngClass]='{componentStyle1:style1isActive}'>[ngClass] TEST!</span>
        </p>
        <p>
        	<span [ngStyle]="{'color':'red','font-weight':'bold'}">Angular testing [ngStyle] inline declaration...</span>
        </p>
        <p>
        	<button (click)="switchMyNgClass()">switch ngClass</button>
        </p>`,
    styles: [`
        .componentStyle1 {
            color: orange;
            font-family: Segoe Print;
        }`]
})
export class NgModelComponent {

    style1isActive: boolean = false;

    switchMyNgClass() {
        this.style1isActive = !this.style1isActive;
    }
}