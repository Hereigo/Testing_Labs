import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { MyAppComponent } from './app.component';

import { MyBoldDirective } from './bold.directive';
import { MyHostDirective } from './host.directive';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [MyAppComponent, MyBoldDirective, MyHostDirective],
    bootstrap: [MyAppComponent]
})
export class AppModule { }