import { Component, OnInit } from '@angular/core';

@Component({
        selector: 'app-passing-data',
        template: `
                <div myColorChange='red'>
                	<span> Send parameter to @Directive by selector tag.</span>
                </div>
                <div  [myColorChange]='colorInDirective'>
                	<span>aaa</span>
                </div>`
})
export class App2Component implements OnInit {

        colorInDirective: string = '';

        ngOnInit(): void {
                this.colorInDirective = 'green';
        }
}