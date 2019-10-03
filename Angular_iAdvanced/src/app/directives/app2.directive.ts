import { Directive, ElementRef, Renderer2, Input } from '@angular/core';

@Directive({
        selector: '[myColorChange]'
})
export class App2Directive {
        // via DI :
        // ElementRef - reference to the element processing by directive
        constructor(private elemRef: ElementRef, private renderer: Renderer2) { }

        @Input('myColorChange') set changeColor(color: string) {
                this.renderer.setStyle(this.elemRef.nativeElement, 'color', color);
        }
}
