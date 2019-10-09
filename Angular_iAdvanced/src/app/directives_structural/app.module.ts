import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

// STRUCTURAL DIRECTIVES - are for change HTML-structure & they NAMED with * before Name !

import { AppIfComponent } from './app-if.component';
import { AppIfDirective } from './app-if.directive';
import { ContextComponent } from './context.component';
import { ContextDirective } from './context.directive';
import { DelayComponent } from './delay.component';
import { DelayDirective } from './delay.directive';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [
        AppIfComponent,
        AppIfDirective,
        ContextComponent,
        ContextDirective,
        DelayComponent,
        DelayDirective
    ],
    bootstrap: [AppIfComponent]
})
export class AppModule { }