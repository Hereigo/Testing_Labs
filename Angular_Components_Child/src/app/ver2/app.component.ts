import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    template: `
    <p>
    <input type='text' [(ngModel)]="varToInput" value="varToInput" />
    </p>
    <child-compo [childInput]="varToInput" (childOutput)="onChanged($event)"></child-compo>
    
    <h4>Output var = {{varForOutput}}</h4>`
})
export class AppComponent {

    varToInput:string = "I'm var To Input.";
    varForOutput:number = 0;

    onChanged(increased:any){

        increased==true?this.varForOutput++:this.varForOutput--;

    }

}