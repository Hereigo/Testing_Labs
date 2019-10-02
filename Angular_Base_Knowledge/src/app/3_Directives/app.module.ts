import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { MyAppComponent } from './app.component';

import { MyBoldDirective } from './bold.directive';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [MyAppComponent, MyBoldDirective],
    bootstrap: [MyAppComponent]
})
export class AppModule { }