import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <div>
    	<h4>Ng-Content Component below:</h4>
    	<!-- To put some CODE INSIDE of <APP-WITH-NG-CONTENT> input-marker ...
            - Use <NG-CONTENT></NG-CONTENT>in child's Html-Template !-->
    	<app-with-ng-content [elementInputToUseInApp]="bindedToElementsInput">
    		<p>{{bindedToElementsInput}}</p>
    		<!-- to show this PARAGRAF - <ng-content></ng-content>in child REUIRED !!! -->
    	</app-with-ng-content>
    	<hr />
    	<button class="btn btn-primary" (click)="onChangeBoundElement()">Change Bound Element</button>
    	<div>`
})
export class AppComponent {

  bindedToElementsInput: string = 'before onChangedFirst()';

  onChangeBoundElement() {

    console.log('APP_Component.onChangeBoundElement() :');

    this.bindedToElementsInput = "AFTER onChangedFirst()";
  }
}
