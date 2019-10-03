import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { MyParamsDirective } from './params.directive';
import { MyHostDirective } from './host.directive';
import { MyChildComponent } from './child.component';


@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [AppComponent, MyChildComponent, MyHostDirective, MyParamsDirective],
    bootstrap: [AppComponent]
})
export class AppModule { }