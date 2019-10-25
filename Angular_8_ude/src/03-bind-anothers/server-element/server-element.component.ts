import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-server-element',
  templateUrl: './server-element.component.html',
  styleUrls: ['./server-element.component.css']
})
export class ServerElementComponent {

  // Make public and visible for another Components (via Alias-Nickname) :
  @Input('elementAlias') element: { type: string, name: string, content: string };

}
