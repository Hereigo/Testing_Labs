import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title = 'a-project';

  allowNewServer = false;

  serverCreationStatus = 'No server was created.';

  serverName = '';

  constructor() {
    setTimeout(() => {
      this.allowNewServer = true;
    }, 3000);
  }

  onServerCreated() {
    this.serverCreationStatus = 'Server was created!';
  }

  onUpdateServerName(event: Event) {

    this.serverName = (<HTMLInputElement>event.target).value;

  }
}
