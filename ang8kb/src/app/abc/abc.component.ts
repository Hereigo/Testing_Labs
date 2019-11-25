import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { IComponentCanDeactivate } from './abc.exit.guard';

@Component({
  selector: 'app-abc',
  templateUrl: './abc.component.html',
})
export class AbcComponent implements IComponentCanDeactivate {
// Route must has : { component: AbcComponent, canDeactivate: [AbcExitGuard] }

  public saved: boolean = false;

  public save() {
    this.saved = true;
  }

  public canDeactivate(): boolean | Observable<boolean> {

    if (!this.saved) {
      return confirm('Data NOT saved? \r\n Are you sure you wish to go?');
    } else {
      return true;
    }
  }
}
