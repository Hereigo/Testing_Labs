import { CanDeactivate } from '@angular/router';
import { Observable } from 'rxjs';

export interface IComponentCanDeactivate {
  canDeactivate: () => boolean | Observable<boolean>;
}

export class AbcExitGuard implements CanDeactivate<IComponentCanDeactivate> {

  public canDeactivate(component: IComponentCanDeactivate): Observable<boolean> | boolean {

    return component.canDeactivate ? component.canDeactivate() : true;
  }

}
