import { Component } from '@angular/core';

@Component({
        selector: 'my-app',
        template: `
                <p>
                	<span>First paragraph with no any attributes ...</span>
                </p>
                <p myColor>
                	<span>Second paragraph with &lt; p myColor &gt; attribute ...</span>
                </p>
                <p>
                	<app-passing-data></app-passing-data>
                </p>`
})
export class AppComponent { }