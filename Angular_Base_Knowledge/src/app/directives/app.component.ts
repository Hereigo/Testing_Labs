import { Component } from '@angular/core';

@Component({
        // selector: '[my-app]' // <div my-app>
        // selector: '.my-app'  // <div class='my-app'>
        selector: 'my-app',     // <my-app></my-app>
        template: `
                <p>
                	<span my-bold>. this . &lt;span my-bold&gt; processed by "MyHostDirective" .</span>
                </p>
                <p>
                	<child-comp-inp [childFontSize]='parentFontSize'></child-comp-inp>
                </p>`
})
export class AppComponent { }