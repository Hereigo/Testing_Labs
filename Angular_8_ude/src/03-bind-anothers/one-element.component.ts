import { Component, Input, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-one-element',
  styles: [`
    div {
        border: solid 1px blue;
        padding: 10px
    }`],
  // SET STYLES IN THIS ELEMENT GLOBALLY !
  encapsulation: ViewEncapsulation.None,
  template: `
    <div class="panel panel-default">
    	<div class="panel-heading">{{ element.name }}</div>
    	<div class="panel-body">{{ element.name }} is created.</div>
    </div>`
})
export class ElementComponent {

  // Make element is public and visible for another Components (via Alias) :
  @Input('elementAlias') element: { content: string };

}
