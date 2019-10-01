import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    template: `
        <p>
        	<strong>[(ngModel)]="intParam" :</strong>
        	<input type='number' [(ngModel)]="appComponentNumParam" />
        </p>
        <p>
        	<strong>[(ngModel)]="strParam" :</strong>
        	<input [(ngModel)]="AppNgModelParam" placeholder="AppNgModelParam" />
        </p>
        <p>
        	<child-comp-inp [intParam]="appComponentNumParam" [strParam]="AppNgModelParam" (outputToParentEvent)="processEvent($event)"></child-comp-inp>
        </p>
        <p>
        	<strong>Output var = {{localNumber}}</strong>
        </p>`
})
export class AppComponent {

    appComponentNumParam: number = 123;
    AppNgModelParam: string = 'AppComponent text';

    localNumber: number = 0;

    processEvent(param: number) {
        this.localNumber = param;
    }
}