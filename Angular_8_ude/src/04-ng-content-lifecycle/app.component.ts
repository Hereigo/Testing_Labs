import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <div style="margin-left: -300px;">
    	<h4>Ng-Content Component below:</h4>
    	<app-with-ng-content *ngFor="let oneElement of appArray" [elementInputOfNgComponent]="oneElement">
    		<p>{{oneElement}}</p>
    		<!-- <NG-CONTENT></NG-CONTENT>_ in a child REUIRED to show this paragraf! -->
    	</app-with-ng-content>
    	<hr />
    	<button class="btn btn-success" (click)="onAddBoundElement()">Add Element</button>&nbsp;
    	<button class="btn btn-primary" (click)="onChangeBoundElement()">Change Element</button>&nbsp;
    	<button class="btn btn-danger" (click)="onDestroyBoundElement()">Destroy Element</button>
    </div>`
})
export class AppComponent {

  appArray: string[] = [];

  oneElement: string = 'before onChangeBoundElement()';

  onAddBoundElement() {
    console.log('APP_COMPONENT.AddElement() :');
    this.appArray.push(this.oneElement);
  }

  onChangeBoundElement() {
    console.log('APP_COMPONENT.ChangeElement() :');
    this.appArray[0] = "AFTER onChangeBoundElement()";
  }

  onDestroyBoundElement() {
    console.log('APP_COMPONENT.DestroyElement() :');
    this.appArray.splice(0, 1);
  }
}
