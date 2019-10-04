import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AsyncComponent } from './async.component';
import { AsyncObservableComponent } from './async-observable.component';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [AsyncComponent, AsyncObservableComponent],
    bootstrap: [AsyncComponent]
})
export class AppModule { }