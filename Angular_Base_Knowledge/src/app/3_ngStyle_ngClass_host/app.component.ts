import { Component } from '@angular/core';

// Directive [ngClass] takes -
// JS-OBJECT { js-class-name : bool (to activate class) }

// [ngClass]="{ verdanaFont : true }"

// Directive [ngStyle] takes - NOT js-object but CSS-STYLES.
// [ngStyle]="{'font-size':'13px', 'font-family':'Verdana'}"

@Component({
    selector: "my-app",
    template: `
        <div [ngClass]="{verdanaFont:isVerdana}">
        	<h3>Hello Angular 8</h3>
        	<p>Angular implements a modular application architecture.</p>
        	<p [ngClass]="specificStylesClass">This paragraph has even whole class of many different styles that is applied to it.</p>
        </div>
        <div [ngClass]="{invisible: visibility}">SDFB.LJNSDB HNJ !!! =)</div>
        <button (click)="toggleVisibility()">Toggle</button>
        <p my-bold>. this . &lt;p my-bold&gt; processed by "MyBoldDirective" & "MyHostDirective" (point by mouse) .</p>`,
    styles: [
        `
        .invisible {
            display: none;
        }
        .verdanaFont {
            font-size: 13px;
            font-family: Verdana;
        }
        .segoePrintFont {
            font-size: 14px;
            font-family: "Segoe Print";
        }
        .navyColor {
            color: navy;
        }
        .bordered {
            border: 2px solid orange;
            padding: 10px;
        }`
    ]
})
export class MyAppComponent {

    isVerdana: boolean = true;

    specificStylesClass = {
        bordered: true,
        navyColor: true,
        segoePrintFont: true,
    };

    // Buttom click to switch ngClass :
    visibility: boolean = true;

    toggleVisibility() {
        this.visibility = !this.visibility;
    }
}