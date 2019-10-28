import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-cockpit',
  template: `
    <p style="border:solid 1px blue; padding: 10px">
    	<label>New Element Name</label>
    	<input type="text" class="form-control" [(ngModel)]="cockpitSrvNameInput">
    		<br/>
    		<button class="btn btn-primary" (click)="onAddElement_EmitEvent()">Add Element</button>
    	</p>`
})
export class CockpitComponent {

  cockpitSrvNameInput = '';

  // <app-cockpit (elementCreatedEvent)="onElementAdded($event)">
  // AppComponent.
  // onElementAdded( cockpitElementCreatedEvent: { elementName: string }) { ...

  @Output() elementCreatedEvent = new EventEmitter<{ elementName: string }>();

  onAddElement_EmitEvent() {
    this.elementCreatedEvent.emit({
      elementName: this.cockpitSrvNameInput
    });
  }
}
