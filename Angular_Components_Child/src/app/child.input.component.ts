import { Component, Input } from '@angular/core';

@Component({
    selector: 'child-comp-inp',
    template: `<div id='chi-wrapper'>
                <h5>{{inputIntParam}}!</h5>
                <h5>{{inputStrParam}}!</h5>
                </div>`,
    styles: [`#chi-wrapper {border: 2px blue solid}`]
})
export class ChildComponentInput {
    @Input() inputIntParam: number;
    @Input() inputStrParam: string;
}