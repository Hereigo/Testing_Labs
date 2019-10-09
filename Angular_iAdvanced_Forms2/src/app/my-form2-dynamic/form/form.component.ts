import { Component } from '@angular/core';
import { ElementBase } from '../model/element-base';
import { FormsService } from '../shared/forms.service';

@Component({
  selector: 'app-my-form',
  templateUrl: './form.component.html',
  providers: [FormsService]
})
export class FormComponent {

  title = 'my title';

  myCompoBaseElements: ElementBase<any>[];

  constructor(private fSvc: FormsService) {

    this.myCompoBaseElements = fSvc.getElements();
  }
}
