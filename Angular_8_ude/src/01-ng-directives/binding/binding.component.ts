import { Component } from '@angular/core';

@Component({
  selector: 'app-binding',
  templateUrl: './binding.component.html',
  styles: [`
    button {
        width: 150px
    }`]
})
export class BindingComponent {

  myText = '...default value...';

  onInputChanged(event: Event) {
    // <input (input)='onInputChanged($event)'>
    this.myText = (<HTMLInputElement>event.target).value;
  }

}
