import { Component } from '@angular/core';

@Component({
    selector: 'my-data',
    template: `
        <div>
        	<h3>{{message}}</h3>
        </div>`,
    styles: [`
        div {
            border: 2px solid red;
            padding: 10px
        }`]
})
export class DataComponent {

    message: string = "In the Data Component.";
}