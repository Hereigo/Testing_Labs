import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-another',
  template: `
    <h4>Another Component works!</h4>
    <p>{{anotherComponentProp.name}} says : {{anotherComponentProp.content}}</p>`
})
export class AnotherComponent {

  @Input('anotherCompPropNick') anotherComponentProp: { type: string, name: string, content: string };

}
