import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    template: `
        <div>
        	<h3>Test</h3>
        </div>`
    ,
    styles: [`
        div {
            border: 2px solid green;
            padding: 10px
        }`]
})
export class AppComponent {
}