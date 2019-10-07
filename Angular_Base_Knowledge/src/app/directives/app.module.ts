import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MyChildComponent } from './child.component';
import { MyHostDirective } from './host.directive';
import { MyParamsDirective } from './params.directive';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [AppComponent, MyChildComponent, MyParamsDirective],
    bootstrap: [AppComponent]
})
export class AppModule { }