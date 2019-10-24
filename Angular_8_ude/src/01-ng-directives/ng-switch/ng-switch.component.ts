import { Component } from '@angular/core';

@Component({
  selector: 'app-ng-switch',
  template: `
    <h3>[ngSwitch]="number" : </h3>
    
    <div [ngSwitch]="number">
    	<ng-template ngSwitchCase="1">{{'Selected number : ' + number + ' - Rezult = ' + number * 10}}</ng-template>
    	<ng-template ngSwitchCase="2">{{'Selected number : ' + number + ' - Rezult = ' + number * 100}}</ng-template>
    	<ng-template ngSwitchDefault >{{'Selected number : ' + number + ' - Rezult = ' + number * 1000}}</ng-template>
    </div>`
})
export class NgSwitchComponent {

  number = 4;

}
