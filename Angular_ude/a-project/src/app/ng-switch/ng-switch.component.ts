import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ng-switch',
  template: `
    <label>Current Count = {{count}}</label>
    <div [ngSwitch]="count">
    	<ng-template ngSwitchCase="1">{{count * 10}}</ng-template>
    	<ng-template ngSwitchCase="2">{{count * 100}}</ng-template>
    	<ng-template ngSwitchDefault >{{count * 1000}}</ng-template>
    </div>`
})
export class NgSwitchComponent {
  count = 4;
}
