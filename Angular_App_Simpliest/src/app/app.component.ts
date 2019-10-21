import { Component } from '@angular/core';
import { OneItem } from './one-item.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  items: OneItem[] = [];

  onAddOneItem() {

    const count = this.items.length + 1;

    const newItem = new OneItem(count, 'Testik_' + count);

    this.items.push(newItem);

    console.log(this.items.length);
  }

  onRemoveItem() {
    console.log('I am removed.');
  }
}
