import { Component, Input } from '@angular/core';

@Component({
    selector: 'child-comp-inp',
    template: `
        <p>
        	<span>Child component with @Input param.</span>
        	<br/>
        	<span my-params [defaultSize]='childFontSize'>. this . &lt;span my-params&gt; processed by "MyParamsDirective" .</span>
        </p>`,
    styles: [`
        p {
            border: 2px blue solid;
            padding: 10px
        }`]
})
export class MyChildComponent {

    // TODO :
    // to do something to make it work!!!
    @Input() childFontSize: string = '36px';

}