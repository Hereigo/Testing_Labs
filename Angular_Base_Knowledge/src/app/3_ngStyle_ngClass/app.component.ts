import { Component, OnInit } from '@angular/core';

// Directive - [ngClass] takes - JS-OBJECT { js-class-name : bool (to activate class) }
// Directive - [ngStyle] takes - Plain CSS-STYLES.

@Component({
    selector: 'my-app',
    template: `
        <p>
        	<span [ngClass]='{componentStyle1:style1isActive}'>[ngClass] TEST!</span>
        </p>
        <p>
        	<span [ngStyle]="{'font-size':'14px', 'font-family':'Segoe Print'}">Angular [ngStyle] (inline) testing...</span>
        </p>
        <p>
        	<button (click)="switchMyNgClass()">switch ngClass</button>
        </p>`,
    styles: [`
        .componentStyle1 {
            color: red;
            font-weight: bold;
        }`]
})
export class AppComponent implements OnInit {
    // can use for debug.
    ngOnInit(): void {
        console.log(" = = = APP COMPONENT HAS INITIALISED = = = ");
    }

    style1isActive: boolean = true;

    switchMyNgClass() {
        this.style1isActive = !this.style1isActive;
    }
}