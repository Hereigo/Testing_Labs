import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-cockpit',
  template: `
    <div class="col-md-6">
    	<label>New Element Name by [(ngModel)]</label>
    	<input type="text" class="form-control" [(ngModel)]="cockpitNameInput">
    		<button class="btn btn-primary" (click)="onAddElement_viaNgModel()">Add Element by [(ngModel)]</button>
    	</div>
    	<div class="col-md-6">
    		<label>New Element Name by #localReference</label>
    		<input type="text" class="form-control" #cockpitLocalReferencedInput>
    			<button class="btn btn-primary" (click)="onAddElement_viaLocalRef(cockpitLocalReferencedInput)">Add Element by #localReference</button>
    		</div>`
})
export class CockpitComponent {

  cockpitNameInput = '';

  // <app-cockpit (elementCreatedEvent)="onElementAdded($event)">
  // AppComponent.onElementAdded( cockpitElementCreatedEvent: { elementName: string }) { ...
  @Output() elementCreatedEvent = new EventEmitter<{ elementName: string }>();

  onAddElement_viaNgModel() {
    this.elementCreatedEvent.emit({
      elementName: this.cockpitNameInput
    });
  }

  onAddElement_viaLocalRef(localReferencedInput: HTMLInputElement) {
    this.elementCreatedEvent.emit({ elementName: localReferencedInput.value });
  }
}
