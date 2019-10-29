import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {

  appArrayForNgContent = [{ name: 'Anna' }, { name: 'Janna' }, { name: 'Marianna' }];

  elementsArray = [{ name: 'First Test Element' }];

  // USE CockpitComponent @Output EVENT : 
  // (eventEmittedFromCockpit) creates new ElementComponent.element & sends it to onElementAdded($event)
  // <app-cockpit (eventEmittedFromCockpit)="onElementAdded($event)"

  onElementAdded(cockpitElementCreatedEvent: { elementName: string }) {

    this.elementsArray.push({
      name: cockpitElementCreatedEvent.elementName
    });
  }

  onChangeFirst() {
    console.log('APP-LifeCycle : ngOnInit() call.');
    this.elementsArray[0].name = 'Changed-Name!';
  }
}
