import { Directive, ElementRef, Renderer2, Input } from '@angular/core';

@Directive({
        selector: '[compoColorTag]'
})
export class AppDirective {
        // via DI :
        // ElementRef - reference to the element processing by directive
        constructor(private elemRef: ElementRef, private renderer: Renderer2) { }

        @Input('compoColorTag') set privateNameToChangeColorMethod(color: string) {

                this.renderer.setStyle(this.elemRef.nativeElement, 'color', color);
        }
}
