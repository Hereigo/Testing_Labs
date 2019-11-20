import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { HomeComponent } from "./home/home.component";
import { ItemComponent } from "./item/item.component";
import { RouteParamsComponent } from "./route-params/route-params.component";
import { RoutingComponent } from "./routing/routing.component";

const routes: Routes = [
  { path: "", component: RoutingComponent },
  { path: "home", component: HomeComponent },
  { path: "item", component: ItemComponent },
  { path: "item/:id", component: ItemComponent },
  { path: "params", component: RouteParamsComponent },
  // { path: '**', component: NotFoundComponent } // a way to process "NotFoundComponent" cases.
  { path: "**", redirectTo: "/" },
];

@NgModule({
  exports: [RouterModule],
  imports: [RouterModule.forRoot(routes)],
})
export class AppRoutingModule { }
