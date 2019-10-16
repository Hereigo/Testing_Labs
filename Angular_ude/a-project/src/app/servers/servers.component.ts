import { Component } from '@angular/core';

@Component({
  selector: 'app-servers-component',
  templateUrl: './servers.component.html'
})
export class ServersComponent {

  allowNewServer = false;
  serverCreated = false;
  serverCreationStatus = 'No server was created.';
  serverName = 'Test Server 1';
  serversArr = ['1', '2'];

  constructor() {
    setTimeout(() => {
      this.allowNewServer = true;
    }, 3000);
  }

  // <button (click)='onServerCreated()' >
  onServerCreated() {
    this.serverCreated = true;
    this.serversArr.push(this.serverName);
    this.serverCreationStatus = 'Server was created with name : ' + this.serverName;
  }

  // <input (input)='onUpdateServerName($event)'>
  onUpdateServerName(event: Event) {
    this.serverName = (<HTMLInputElement>event.target).value;
  }

}
