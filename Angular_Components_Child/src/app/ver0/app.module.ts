import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MyChildComponent } from './mychild.component';

@NgModule({
    imports: [ BrowserModule, FormsModule ],
    declarations: [AppComponent, MyChildComponent],
    bootstrap: [AppComponent]
})
export class AppModule{}
