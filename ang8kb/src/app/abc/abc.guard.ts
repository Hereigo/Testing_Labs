import {ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot} from '@angular/router';
import {Observable} from 'rxjs';

export class AbcGuard implements CanActivate {

    public canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | boolean {

        return confirm('Redirect Guarded! \r\n Are you sure you wish to go?');
    }
}
