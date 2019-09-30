import { Directive, ElementRef, Renderer2 } from '@angular/core';

@Directive({
    selector: '[my-bold]'
})
export class MyBoldDirective {

    // constructor(private elementRef: ElementRef) {

    //     this.elementRef.nativeElement.style.fontWeight = "bold";
    // }

    // VARIAN 2 :

    // Renderer2 - is a service to put into Directive-const and manipulate styled element more comfortable.

    constructor(private elementRef: ElementRef, private renderer: Renderer2){
         
        this.renderer.setStyle(this.elementRef.nativeElement, "font-weight", "bold");
    }
}