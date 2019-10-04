import { Directive, Input, TemplateRef, ViewContainerRef } from '@angular/core';

@Directive({
        selector: '[delayDrectiveMark]'
})
export class DelayDirective {

        // TemplateRef - template for creating View. 
        // Ref to - '<div *myIfDirectiveMark ...'

        // ViewContainerRef - Container for View, Binded to HTML-element.

        constructor(private templeRef: TemplateRef<any>, private viewContRef: ViewContainerRef) { }

        // <div *delayDrectiveMark='500'>Element 1</div>
        @Input('delayDrectiveMark') set delayTime(delayMilliseconds: number) {

                // create view, using template, after 'gettingValue' mls delay
                setTimeout(() => {
                        this.viewContRef.createEmbeddedView(this.templeRef);
                },
                        delayMilliseconds);
        }
}
