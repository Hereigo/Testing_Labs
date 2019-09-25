import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    template: `<div id='wrapper'>
                <label> AppNgModelParam : </label> 
                <input [(ngModel)]="AppNgModelParam" placeholder="AppNgModelParam">
                <br><br>
                 <child-comp></child-comp>
                 <br>
                 <child-comp-inp [inputIntParam]="appComponentNumParam" [inputStrParam]="AppNgModelParam"></child-comp-inp>
                 <br>
                 <label> [inputIntParam]=AppComponentNumParam : </label>
                 <input type='number' [(ngModel)]="appComponentNumParam" />
                 <br>
                 </div>`,
    styles: [`h2, p {color:red;} 
            #wrapper {border: 1px purple solid; padding:10px}`]
})
export class AppComponent {
    appComponentNumParam:number = 123;
    AppNgModelParam:string = 'Defined in App';
}