import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    template: `<div id='wrapper'>
                <label> Write your name : </label>
                 <input [(ngModel)]="name" placeholder="name">
                 <h1>Hello, {{name}}!</h1>
                 <br>
                 <child-comp></child-comp>
                 <child-comp-inp [inputIntParam]="appComponentParam1" [inputStrParam]="appComponentParam2"></child-comp-inp>
                 <br>
                 <label> Change the number : </label>
                 <input type='number' [(ngModel)]="appComponentParam1" />
                 <br>
                 </div>`,
    styles: [`h2, p {color:red;} 
            #wrapper {border: 1px purple solid; padding:10px}`]
})
export class AppComponent {
    appComponentParam1:number = 123;
    appComponentParam2:string = 'A...';
}