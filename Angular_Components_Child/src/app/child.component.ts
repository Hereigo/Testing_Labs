import { Component, Input } from '@angular/core';

@Component({
    selector: 'child-comp',
    template: `<div id='ch-wrapper'><h4>A Child Component with {{childParam}}!</h4></div>`,
    styles: [`h4, p {color:red;} 
            #ch-wrapper {border: 2px green solid}`]
})
export class ChildComponent {
    childParam="Child-Parameter";
}