import { Component, Input } from '@angular/core';

@Component({
    selector: 'child-comp',
    template: `<div id='ch-wrapper'><h5>A Child Component with Child param - {{childParam}}</h5></div>`,
    styles: [`h5, p {color:red;} 
            #ch-wrapper {border: 2px green solid}`]
})
export class ChildComponent {
    childParam="Child-Parameter";
}