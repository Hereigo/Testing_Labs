import { Directive, ElementRef, Renderer2 } from '@angular/core';

@Directive({
        selector: '[myColor]'
})
export class AppDirective {
        // via DI :
        // ElementRef - reference to the element processing by directive
        constructor(elemRef: ElementRef, render: Renderer2) {

                render.setStyle(elemRef.nativeElement, 'color', 'green');
        }
}
