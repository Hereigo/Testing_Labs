import { Component } from '@angular/core';

import { ElementBase } from './model/element-base';
import { FormsService } from './shared/forms.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [FormsService]
})
export class AppComponent {

  title = 'my title';

  elements: ElementBase<any>[];

  constructor(private fSvc: FormsService) {

    this.elements = fSvc.getElements();
  }
}
