import { Directive, Input, HostListener, ElementRef } from '@angular/core';

@Directive({
        selector: '[myCoords]'
})
export class MouseoverDirective {

        constructor(private elemref: ElementRef) { }

        // Listen of 'mousemove' & send $event-object to it :

        @HostListener('mousemove', ['$event'])
        onMouseMoveAct(evnt: MouseEvent) {

                let msg = 'X ' + evnt.offsetX + ' Y ' + evnt.offsetY;

                this.elemref.nativeElement.innerHTML = msg;
        }
}
