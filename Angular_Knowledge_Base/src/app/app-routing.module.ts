import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ItemComponent } from './item/item.component';
import { SecondPageComponent } from './second-page/second-page.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'pageTwo', component: SecondPageComponent },
  {
    path: 'item', component: ItemComponent, children:
      [
        // canActivate - for authority
        // canLoad - ...
        // resolve (dictionary) - to check data before onInit Component
        // loadChildren: () => import('./photos/photos.module').then(x => x.PhotosModule), 
        //  - lazy loaded route in case of allowed (see more on angular.io)
      ]
  },
  { path: 'item/:id', component: ItemComponent },
  // { path: '**', component: NotFoundComponent } - to process "NotFoundComponent" cases.
  { path: '**', redirectTo: '/' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
