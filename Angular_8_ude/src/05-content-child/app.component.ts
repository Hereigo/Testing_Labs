import { Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <div>
    	<h4>App Component :</h4>
    	<app-content-child></app-content-child>
    </div>`
})
export class AppComponent { }
