import { Component, Input } from '@angular/core';

@Component({
    selector: 'child-comp-inp',
    template: `
        <p>
            <span>Child component with @Input param.</span>
            <br>
        	<span my-params>. this . &lt;span my-bold&gt; processed by "MyParamsDirective" .</span>
        </p>`,
    styles: [`
        p {
            border: 2px blue solid;
            padding: 10px
        }`]
})
export class MyChildComponent { 

    @Input() childFontSize: number;

}