import { Directive, ElementRef, Renderer2, HostBinding, HostListener } from '@angular/core';

@Directive({
    selector: '[my-bold]',
    host: {
        '(mouseenter)': 'onMouseEnter()',
        '(mouseleave)': 'onMouseLeave()'
    }
})
export class MyHostDirective {

    constructor(private elementRef: ElementRef, private renderer: Renderer2) {

        this.renderer.setStyle(this.elementRef.nativeElement, "cursor", "pointer");
    }

    // HOST-BINDING - to bind CLASS-PROPERTY with HTML-ELEMENT-PROPERTY :

    private fontWeight = "normal";

    @HostBinding("style.fontWeight") get getFontWeight() {
        return this.fontWeight;
    }

    @HostBinding("style.cursor") get getCursor() {
        return "pointer";
    }

    // @HostListener("mouseenter") onMouseEnter() {
    //     this.setFontWeight("normal");
    // }

    // @HostListener("mouseleave") onMouseLeave() {
    //     this.setFontWeight("bold");
    // }

    // @Directive.host: ($event) - replaced @HostListener()

    onMouseEnter() {
        this.setFontWeight("bold");
    }
    onMouseLeave() {
        this.setFontWeight("normal");
    }

    private setFontWeight(val: string) {
        this.renderer.setStyle(this.elementRef.nativeElement, "font-weight", val);
    }
}