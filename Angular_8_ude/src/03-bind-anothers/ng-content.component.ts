import { Component, ViewEncapsulation } from '@angular/core';

@Component({
    selector: 'app-with-ng-content',
    styles: [`
        div {
            border: solid 1px blue;
            padding: 10px
        }`],
    // SET STYLES IN THIS ELEMENT GLOBALLY !
    encapsulation: ViewEncapsulation.None,
    template: `
        <span>One child :</span>
        <ng-content></ng-content>` // Projecting CONTENT from PARENT via <app-with-ng-content> tag
})
export class NgContentComponent { }