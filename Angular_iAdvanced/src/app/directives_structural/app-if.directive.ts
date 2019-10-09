import { Directive, Input, TemplateRef, ViewContainerRef } from '@angular/core';

@Directive({
        selector: '[myIfDirectiveMark]'
})
export class AppIfDirective {

        // TemplateRef - template for creating View. 
        // Ref to - '<div *myIfDirectiveMark ...'

        // ViewContainerRef - Container for View, Binded to HTML-element.

        constructor(private templeRef: TemplateRef<any>, private viewContRef: ViewContainerRef) { }

        @Input('myIfDirectiveMark')
        set myIfValue(condition: boolean) {

                if (condition) {
                        // create view using template
                        this.viewContRef.createEmbeddedView(this.templeRef);
                } else {
                        // remove view from container
                        this.viewContRef.clear();
                }
        }
}
