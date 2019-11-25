import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AbcComponent } from './abc/abc.component';
import { AbcExitGuard } from './abc/abc.exit.guard';
import { AbcGuard } from './abc/abc.guard';
import { HomeComponent } from './home/home.component';
import { TestComponent } from './routes/test.component';

const testsRoutes: Routes = [
  // AbcComponent must implements IComponentCanDeactivate - to use CanDeactivate:
  { path: 'abc', component: AbcComponent, canDeactivate: [AbcExitGuard] },
  { path: 'abcd', component: AbcComponent, canActivate: [AbcGuard] },
  // AppModule must have - providers: [AbcGuard] ! - to use CanActivate:
];

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'test', component: TestComponent },
  { path: 'test/:id', component: TestComponent },
  { path: 'test/:id', children: testsRoutes }, // CHILDREN!
  // pathMatch: 'full' - means: Only for 'contact' (not for 'contact/*')
  { path: 'contact', pathMatch: 'full', redirectTo: '/test' },
  { path: '**', redirectTo: '/' },
];

@NgModule({
  exports: [RouterModule],
  imports: [RouterModule.forRoot(appRoutes)],
})
export class AppRoutingModule { }
