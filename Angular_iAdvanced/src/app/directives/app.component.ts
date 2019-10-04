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
                <p>
                	<app-passing-data></app-passing-data>
                </p>`
})
export class AppComponent implements OnInit {

        localColorVar: string;

        ngOnInit(): void {
                this.localColorVar = 'green';
        }
}