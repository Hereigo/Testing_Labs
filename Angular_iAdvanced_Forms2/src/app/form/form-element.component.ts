import { Component, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

import { ElementBase } from '../model/element-base';

@Component({
  selector: 'form-element',
  templateUrl: './form-element.component.html'
})
export class FormElementComponent {

  @Input()
  public element: ElementBase<any>;

  @Input()
  form: FormGroup;

  constructor() { }

  // GET Control State FROM FORM.
  get isValid() {
    return this.form.controls[this.element.key].valid;
  }

  get isDirty() {
    return this.form.controls[this.element.key].dirty;
  }
}
