import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { RepetComponent } from './repeat.component';
import { AppDirective } from './app.directive';
import { RepeatDirective } from './repeat.directive';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [AppComponent, AppDirective, RepetComponent, RepeatDirective],
    bootstrap: [AppComponent]
})
export class AppModule { }