import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-another',
  template: `
    <p>{{anotherComponentProp.name}} says : {{anotherComponentProp.content}}</p>`
})
export class AnotherComponent {

  // Make public and visible for another Components :
  @Input('anotherCompPropNick') anotherComponentProp: { type: string, name: string, content: string };

}
