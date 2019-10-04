import { Directive, Input, TemplateRef, ViewContainerRef } from '@angular/core';

@Directive({
        selector: '[userCardDirecMark]'
})
export class ContextDirective {

        // TemplateRef - template for creating View. 
        // Ref to - '<div *userCardDirecMark  ...'

        // ViewContainerRef - Container for View, Binded to HTML-element.

        constructor(private templeRef: TemplateRef<any>, private viewContRef: ViewContainerRef) { }

        ngOnInit() {
                let ctx: UserCardContext = new UserCardContext('Ivan', 'Ivanoff');
                this.viewContRef.createEmbeddedView(this.templeRef, ctx);
        }

        // UserCardContext.firstName & lastName will send as a Context 
        //  - into ViewContainer according to selector: '[userCardDirecMark]'

        // <div *userCardDirecMark='let fn = firstName; let ln = lastName;'>
}

class UserCardContext {

        public firstName: string;
        public lastName: string;

        constructor(fName: string, lName: string) {
                this.firstName = fName;
                this.lastName = lName;
        }
}