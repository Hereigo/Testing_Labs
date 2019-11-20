import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DetailsComponent } from './details/details.component';
import { ItemComponent } from './item/item.component';
import { ItemRoutingModule } from './item-routing.module';
import { ListComponent } from './list/list.component';

@NgModule({
  declarations: [ItemComponent, DetailsComponent, ListComponent],
  imports: [CommonModule, ItemRoutingModule]
})
export class ItemModule { }
