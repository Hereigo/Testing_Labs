import { Component } from '@angular/core';

@Component({
  selector: 'app-server-component',
  templateUrl: './server.component.html',
  styleUrls: ['./server.component.css']
})
export class ServerComponent {

  serverId = 10;
  serverStatus: string;

  constructor() {
    this.serverStatus = Math.random() > 0.5 ? 'online' : 'offline';
  }

  getColor() {
    return this.serverStatus === 'online' ? 'green' : 'red';
  }

  getServerStatus() {
    return this.serverStatus;
  }
}
