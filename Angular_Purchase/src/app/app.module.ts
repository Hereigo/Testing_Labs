import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { MyItemsComponent7 } from './app.component';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [MyItemsComponent7],
    bootstrap: [MyItemsComponent7]
})

export class MainAppModule { }