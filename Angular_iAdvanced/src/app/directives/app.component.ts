import { Component, OnInit } from '@angular/core';

@Component({
        selector: 'my-app',
        template: `
                <div compoColorTag='red'>
                	<p>here &lt;div compoColorTag='red'&gt; - sends 'color' as param to @Directive.Input()...</p>
                </div>
                <div [compoColorTag]='localColorVar'>
                	<p>here &lt;div [compoColorTag]='localColorVar'&gt; - also sends 'color' as param to @Directive.Input()</p>
                </div>
                <hr/>
                <p>
                	<repeater-block></repeater-block>
                </p>
                <hr/>
                <p>
                	<confirm-block></confirm-block>
                </p>`
})
export class AppComponent implements OnInit {

        localColorVar: string;

        ngOnInit(): void {
                this.localColorVar = 'green';
        }
}