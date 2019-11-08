import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'pageTwo', component: HomeComponent },
  {
    path: 'pageThree', component: HomeComponent, children:
      [
        // canActivate - for authority
        // canLoad - ...
        // resolve (dictionary) - to check data before onInit Component
        // loadChildren: () => import('./photos/photos.module').then(x => x.PhotosModule), 
        //  - lazy loaded route in case of allowed (see more on angular.io)
      ]
  },
  { path: '**', component: HomeComponent }
  // { path: '**', component: NotFoundComponent } - to process "NotFoundComponent" cases.
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
