import { Component } from '@angular/core';

// Directive [ngClass] takes -
// JS-OBJECT { js-class-name : bool (to activate class) }

// [ngClass]="{ verdanaFont : true }"

@Component({
    selector: "my-app-comp",
    template: `
        <div [ngClass]="{verdanaFont:isVerdana}">
        	<h3>Hello Angular 8</h3>
        	<p>Angular implements a modular application architecture.</p>
        	<p [ngClass]="specificStylesClass">This paragraph has even whole class of many different styles that is applied to it.</p>
        </div>`,
    styles: [
        `
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
}