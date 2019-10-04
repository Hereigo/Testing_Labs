import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppDirective } from './app.directive';
import { ConfirmComponent } from './confirm.component';
import { ConfirmDirective } from './confirm.directive';
import { MouseoverComponent } from './mouseover.component';
import { MouseoverDirective } from './mouseover.directive';
import { RepeatComponent } from './repeat.component';
import { RepeatDirective } from './repeat.directive';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [
        AppComponent,
        AppDirective,
        ConfirmComponent,
        ConfirmDirective,
        MouseoverComponent,
        MouseoverDirective,
        RepeatComponent,
        RepeatDirective
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }