import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: [`
    div {
        margin: 30px;
    }`]
})
export class AppComponent {

  showSecret = false;
  log = [];

  onToggleDetails() {
    this.showSecret = !this.showSecret;
    this.log.push(new Date().toLocaleTimeString());
  }

}
