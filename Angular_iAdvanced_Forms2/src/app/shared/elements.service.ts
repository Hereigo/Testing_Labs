import { Injectable } from '@angular/core';
import { ElementBase } from '../model/element-base';
import { FormControl, Validators, FormGroup } from '@angular/forms';

@Injectable()
export class ElementsService {

  constructor() { }

  toFormGroup(elements: ElementBase<any>[]) {
    const group: any = {};

    elements.forEach(
      element => {
        group[element.key] = element.required ?
          new FormControl(element.value || '', Validators.required) : // Should Validate HERE
          new FormControl(element.value || '');
      }
    );

    return new FormGroup(group);
  }
}
