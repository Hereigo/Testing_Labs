import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <!-- CockpitCompon. @Output() serverCreatedEvent = new EventEmitter<{ serverName: string, serverContent: string }>(); -->
    <app-cockpit (serverCreatedEvent)="onServerAdded($event)" (blueprintCreatedEvent)="onBlueprintAdded($event)"></app-cockpit>
    <hr />
    <!-- Bind AppComponent.serverElements[i] to ServerElementComponent.Input('elementAlias') element-property -->
    <app-server-element *ngFor="let serverElement of serverElements" [elementAlias]="serverElement"></app-server-element>`
})
export class AppComponent {

  serverElements = [{ type: 'server', name: 'TestServer_1', content: 'Just a test.' }];

  onServerAdded(serverData: { serverName: string, serverContent: string }) {
    this.serverElements.push({
      type: 'server',
      name: serverData.serverName,
      content: serverData.serverContent
    });
  }

  onBlueprintAdded(blueprintData: { serverName: string, serverContent: string }) {
    this.serverElements.push({
      type: 'blueprint',
      name: blueprintData.serverName,
      content: blueprintData.serverContent
    });
  }
}
