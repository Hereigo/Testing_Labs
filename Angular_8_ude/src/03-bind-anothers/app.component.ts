import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {

  appPropertyCollection = [{ type: 'type 1', name: 'Somebody', content: 'Bla-bla-bla ...' }];

  onAddOneAnother(incomingObject: { name: string, content: string }) {


    this.appPropertyCollection.push({ type: '', name: 'New one.', content: incomingObject.content });



  }

}
