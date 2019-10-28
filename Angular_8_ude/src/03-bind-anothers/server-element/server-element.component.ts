import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-server-element',
  template: `
    <div class="panel panel-default">
    	<div class="panel-heading">{{ element.name }}</div>
    	<div class="panel-body">
    		<p>
    			<strong *ngIf="element.type === 'server'" style="color: red">{{ element.content }}</strong>
    			<em *ngIf="element.type === 'blueprint'">{{ element.content }}</em>
    		</p>
    	</div>
    </div>`
})
export class ServerElementComponent {

  // Make element is public and visible for another Components (via Alias) :
  @Input('elementAlias') element: { type: string, name: string, content: string };

}
