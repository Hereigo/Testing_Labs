import { Component } from '@angular/core';

@Component({
  selector: 'app-ngFor-ngStyle',
  templateUrl: './ngFor-ngStyle.component.html',
  styleUrls: ['./ngFor-ngStyle.component.css']
})
export class NgForNgStyleComponent {

  serversCountAllowed = 6;

  servers: object[] = [];

  onAddServer() {
    this.servers.push({
      name: 'One yet Server',
      status: Math.random() > 0.5 ? 'online' : 'offline'
    });
  }

  onRemoveServer(id: number) {
    this.servers.splice(id, 1);
  }
}
