import { Component } from '@angular/core';

@Component({
  selector: 'app-errors',
  templateUrl: './errors.component.html',
  styleUrls: ['./errors.component.css']
})
export class ErrorsComponent {

  public servers: string[] = [];

  onAddServer() {
    this.servers.push('One yet Server');
  }

  onRemoveServer(id: number) {

    const positionToDelete = id + 1;

    this.servers.splice(positionToDelete, 1);
  }

}
