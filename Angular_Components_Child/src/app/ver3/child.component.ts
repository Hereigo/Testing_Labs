import { Component } from '@angular/core';

@Component({
    selector: 'child-comp',
    template: `
        <div style='border: 2px solid blue; padding:10px'>
        	<p>Child Local Number = {{childNumber}}</p>
        </div>`
})
export class ChildComponent {

    childNumber: number = 0;

    increment() { this.childNumber++; }
    decrement() { this.childNumber--; }
}