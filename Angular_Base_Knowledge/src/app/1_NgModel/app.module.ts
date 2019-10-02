import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ChildComponentInput } from './child.input.component';

import { MySecondModule } from './module2/second.module'; // SECOND-Module imported!

@NgModule({
    imports: [BrowserModule, FormsModule, MySecondModule],
    declarations: [AppComponent, ChildComponentInput],
    bootstrap: [AppComponent]
})
export class AppModule { }