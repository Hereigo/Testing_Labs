import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';

import { DataModule } from './data/data.module'; // DATA-Module imported!

@NgModule({
    imports: [BrowserModule, FormsModule, DataModule],
    declarations: [AppComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }