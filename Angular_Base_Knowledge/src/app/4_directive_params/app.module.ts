import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { MyBoldDirective } from './params.directive';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [AppComponent, MyBoldDirective],
    bootstrap: [AppComponent]
})
export class AppModule { }