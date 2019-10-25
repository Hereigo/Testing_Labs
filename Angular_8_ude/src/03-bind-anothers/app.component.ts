import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {

  appPropertyCollection = [{ type: 'type 1', name: 'Somebody', content: 'Bla-bla-bla ...' }];

}
