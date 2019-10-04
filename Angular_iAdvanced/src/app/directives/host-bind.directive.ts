import { Directive, HostListener, ElementRef, HostBinding } from '@angular/core';

@Directive({
        selector: '[myClickableElement]'
})
export class HostBindDirective {

        constructor(private elemRef: ElementRef) {
                elemRef.nativeElement.style.cursor = 'pointer';
        }

        // This Binding means : <p myClickableElement [class.pressed]='isClicked'>
        @HostBinding('class.pressed')
        isClicked: boolean = false;

        @HostListener('mousedown')
        onMouseDownAction() {
                this.isClicked = true;
        }

        @HostListener('mouseup')
        onMouseUpAction() {
                this.isClicked = false;
        }
}
