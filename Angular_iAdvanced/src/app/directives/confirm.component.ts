import { Component } from '@angular/core';

@Component({
  selector: 'confirm-block',
  template: `
    <p>
    	<label>My Form :</label>
    	<br/>
    	<br/>
    	<button [myConfirm]='localOnDeleteAction'>Delete</button>
    </p>`
})
export class ConfirmComponent {

  localOnDeleteAction() {
    console.log("onDelete called.");
  }
}