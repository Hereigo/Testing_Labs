import { Directive, ElementRef, Renderer2, Input } from '@angular/core';

// Directive can be used as ATTRIBUTE or as ElEMENT (equiavlent)

@Directive({
        selector: '[repeatMe], repeatMe'
})
export class RepeatDirective {

        @Input() message: string;
        @Input() count: number;

        constructor(private elemRef: ElementRef, private renderer: Renderer2) { }

        ngOnInit() {
                for (let index = 0; index < this.count; index++) {

                        // Create div for Directive-marked element.
                        let myNewElem: HTMLDivElement = this.renderer.createElement('div');
                        this.renderer.appendChild(this.elemRef.nativeElement, myNewElem);

                        // Set text for this new element.
                        myNewElem.innerHTML = this.message;
                }
        }
}
