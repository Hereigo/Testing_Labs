import { Component, Input, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-one-element',
  template: `
    <div class="panel panel-default">
    	<div class="panel-heading">{{ element.name }}</div>
    	<div class="panel-body">{{ element.name }} is created.</div>
    </div>`,
  styles: [`
    div {
        border: solid 1px blue;
        padding: 10px
    }`],
  // Set STYLES in this element GLOBALLY.
  encapsulation: ViewEncapsulation.None
})
export class ElementComponent {

  // Make element is public and visible for another Components (via Alias) :
  @Input('elementAlias') element: { content: string };

}
