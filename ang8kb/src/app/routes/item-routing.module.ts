import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DetailsComponent } from './details/details.component';
import { ItemComponent } from './item/item.component';
import { ListComponent } from './list/list.component';

const routes: Routes = [
    {
        path: 'item', component: ItemComponent,
        children: [
            {
                path: 'list',
                component: ListComponent
            },
            {
                path: 'details',
                component: DetailsComponent
            }
        ]
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class ItemRoutingModule { }