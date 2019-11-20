import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { ItemComponent } from './routes/item/item.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'item', component: ItemComponent }
  // { path: '**', component: NotFoundComponent } // a way to process "NotFoundComponent" cases.
  // { path: '**', redirectTo: '' }, - Does NOT work with Children-Routes...((
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
