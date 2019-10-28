import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <div>
    	<h4>COCKPIT : (sends its input-data via @Output() EventEmitter<>)
    	</h4>
    	<!-- USE Sub-Components @Output EVENT :
          CockpitComponent.
          @Output() elementCreatedEvent = new EventEmitter<{ elementName: string }>(); -->
    	<app-cockpit (elementCreatedEvent)="onElementAdded($event)"></app-cockpit>
    	<hr />
    	<h4>ELEMENTS : (created by Cockpit and inserted into AppComponent array)</h4>
    	<!-- INJECT data into Sub-Components @Input PROPERTY (using its Alias) :
          Bind AppComponent.elementsArray[i] to ElementElementComponent.Input('elementAlias') element-property -->
    	<app-one-element *ngFor="let element of elementsArray" [elementAlias]="element"></app-one-element>`
})
export class AppComponent {

  elementsArray = [{ name: 'First Test Element' }];

  // USE CockpitComponent @Output EVENT : 
  // (elementCreatedEvent) creates new ElementComponent.element & sends it to onElementAdded($event)
  // <app-cockpit (elementCreatedEvent)="onElementAdded($event)"

  onElementAdded(cockpitElementCreatedEvent: { elementName: string }) {

    this.elementsArray.push({
      name: cockpitElementCreatedEvent.elementName
    });
  }
}
