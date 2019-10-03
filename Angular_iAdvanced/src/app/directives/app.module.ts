import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { App2Component } from './app2.component';
import { AppDirective } from './app.directive';
import { App2Directive } from './app2.directive';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [AppComponent, AppDirective, App2Component, App2Directive],
    bootstrap: [AppComponent]
})
export class AppModule { }