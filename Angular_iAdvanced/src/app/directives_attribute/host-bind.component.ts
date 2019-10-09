import { Component } from '@angular/core';

@Component({
  selector: 'host-bind-block',
  template: `
    <p myClickableElement>
    	<label>Click me 1</label>
    </p>
    <p myClickableElement>
    	<label>Click me 2</label>
    </p>`,
  styles: [`
    .pressed {
        background-color: orange;
    }`]
})
export class HostBindComponent {

}