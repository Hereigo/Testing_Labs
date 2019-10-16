import { Component } from '@angular/core';

@Component({
  selector: 'app-servers-component',
  templateUrl: './servers.component.html'
})
export class ServersComponent {

  title = 'a-project';
  allowNewServer = false;
  serverCreationStatus = 'No server was created.';
  serverName = 'Test Server 1';

  constructor() {
    setTimeout(() => {
      this.allowNewServer = true;
    }, 3000);
  }

  // <button (click)='onServerCreated()' >
  onServerCreated() {
    this.serverCreationStatus = 'Server was created with name : ' + this.serverName;
  }

  // <input (input)='onUpdateServerName($event)'>
  onUpdateServerName(event: Event) {
    this.serverName = (<HTMLInputElement>event.target).value;
  }

}
