import { NgModule } from '@angular/core';

import { MySecondComponent } from './second.component';

// MySecondComponent - DECLARATED & EXPORTED!

@NgModule({
    declarations: [MySecondComponent],
    exports: [MySecondComponent]
})
export class MySecondModule { }