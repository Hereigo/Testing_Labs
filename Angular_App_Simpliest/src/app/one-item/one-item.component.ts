import { Component } from '@angular/core';
import { OneItem } from '../one-item.model';

@Component({
  selector: 'app-one-item',
  templateUrl: './one-item.component.html',
  styleUrls: ['./one-item.component.css']
})
export class OneItemComponent {

  public item: OneItem;

}
