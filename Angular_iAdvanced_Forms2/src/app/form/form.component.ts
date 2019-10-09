import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

import { ElementsService } from '../shared/elements.service';
import { ElementBase } from '../model/element-base';

@Component({
  selector: 'dynamic-form',
  templateUrl: './form.component.html',
  providers: [ElementsService]
})
export class FormComponent implements OnInit {

  @Input() elements: ElementBase<any>[] = [];

  // object of Model
  form: FormGroup;

  // ElementService - to Convert 'OUR ElementBase' into '@angular.FormGroup'
  constructor(private eSvc: ElementsService) { }

  ngOnInit() {
    this.form = this.eSvc.toFormGroup(this.elements);
  }

  onMyFormSubmit() {

    if (this.form.valid) {
      console.log(this.form.value);
    }
  }
}
