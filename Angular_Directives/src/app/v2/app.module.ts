import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { MyAppComponent } from './app.component';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [MyAppComponent],
    bootstrap: [MyAppComponent]
})
export class AppModule { }