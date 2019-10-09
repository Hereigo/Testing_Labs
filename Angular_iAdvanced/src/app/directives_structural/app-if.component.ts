import { Component } from '@angular/core';

@Component({
        selector: 'my-app',
        template: `
                <div *myIfDirectiveMark='visib'>
                	<p>&lt;div *myIfDirectiveMark = 'true/false' &gt; - now visible!</p>
                </div>
                <button (click)='changeVisibility()'>Change visibility</button>
                <hr/>
                <my-delay-block></my-delay-block>
                <hr/>
                <my-context-block></my-context-block>
                <hr/>`
})
export class AppIfComponent {

        visib: boolean = false;

        changeVisibility() {
                this.visib = !this.visib;
        }
}