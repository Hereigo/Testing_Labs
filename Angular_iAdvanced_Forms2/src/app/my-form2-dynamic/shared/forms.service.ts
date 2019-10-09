import { Injectable } from '@angular/core';

import { ElementBase } from '../model/element-base';
import { DropDownElement } from '../model/dropdown-element';
import { TextBoxElement } from '../model/textbox-element';

@Injectable()
export class FormsService {

  getElements() {

    let elements: ElementBase<any>[] = [

      new TextBoxElement({
        key: 'firstname',
        label: 'First name',
        required: true,
        order: 1
      }),
      new TextBoxElement({
        key: 'lastname',
        label: 'Last name',
        required: true,
        order: 2
      }),
      new TextBoxElement({
        key: 'email',
        label: 'Email',
        type: 'email',
        required: true,
        order: 3
      }),
      new DropDownElement({
        key: 'language',
        label: 'Language',
        order: 4,
        options: [
          { key: '1', value: 'Ukrainian' },
          { key: '2', value: 'English' },
          { key: '3', value: 'Russian' }
        ]
      })
    ];

    return elements.sort((a, b) => a.order - b.order);
  }
}
