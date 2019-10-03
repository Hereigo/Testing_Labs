import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    template: `
        <p>
        	<strong>[(ngModel)] =</strong>
        	<input [(ngModel)]="ngModelVar" placeholder="ngModelVar" />
        </p>
        <p>
        	<child-comp-inp [childInput]="ngModelVar" (outputToParentEvent)="processChildOutEvent($event)"></child-comp-inp>
        </p>
        <p>
        	<strong>Parent var = {{localVar2}}</strong>
        </p>`
})
export class InputComponent {

        ngModelVar: string = 'App.Component text';
        localVar2: string = '...';
    
        processChildOutEvent(param: string) {
            this.localVar2 = param;
        }
}