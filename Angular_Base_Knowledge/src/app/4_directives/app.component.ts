import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    template: `
        <div>
        	<p>
        		<span my-bold>. this . &lt;span my-bold&gt; processed by "MyHostDirective" .</span>
        	</p>
        </div>
        <div id='child'>
        	<p>
        		<child-comp-inp [childFontSize]='parentFontSize'></child-comp-inp>
        	</p>
        	<label>FontSize for Child-Component :</label>
        	<input type='number' [(ngModel)]='parentFontSize'/>
        </div>`
})
export class AppComponent {
    parentFontSize: number = 14;
}