import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-cockpit',
  template: `
    <label>Server Name</label>
    <input type="text" class="form-control" [(ngModel)]="newServerName">
    	<label>Server Content</label>
    	<input type="text" class="form-control" [(ngModel)]="newServerContent">
    		<br/>
    		<button class="btn btn-primary" (click)="onAddServer()">Add Server</button>&nbsp;
    		<button class="btn btn-primary" (click)="onAddBlueprint()">Add Server Blueprint</button>`
})
export class CockpitComponent {

  // <app-cockpit (serverCreated)="onServerAdded($event)"
  // AppComponent.onServerAdded(serverData: { serverName: string, serverContent: string }) { ...
  @Output() serverCreatedEvent = new EventEmitter<{ serverName: string, serverContent: string }>();
  @Output() blueprintCreatedEvent = new EventEmitter<{ serverName: string, serverContent: string }>();

  newServerName = '';
  newServerContent = '';

  onAddServer() {
    this.serverCreatedEvent.emit({
      serverName: this.newServerName,
      serverContent: this.newServerContent
    });
  }

  onAddBlueprint() {
    this.blueprintCreatedEvent.emit({
      serverName: this.newServerName,
      serverContent: this.newServerContent
    });
  }
}
