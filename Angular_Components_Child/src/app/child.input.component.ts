import { Component, Input } from '@angular/core';

@Component({
    selector: 'child-comp-inp',
    template: `<div id='chi-wrapper'>
                    <label>@Input() inputIntParam: number;</label>
                    <strong> = {{inputIntParam}}</strong>
                    <br>
                    <label>@Input() inputStrParam: string;</label>
                    <strong> = {{inputStrParam}}</strong>
                </div>`,
    styles: [`#chi-wrapper {border: 2px blue solid; padding: 10px}`]
})
export class ChildComponentInput {
    @Input() inputIntParam: number;
    @Input() inputStrParam: string;
}