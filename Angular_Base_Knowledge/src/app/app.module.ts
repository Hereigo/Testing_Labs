import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { InputComponent } from './input.component';
import { InputSubComponent } from './input2.component';

import { NgModelComponent } from './ngClass.component';

import { ViewChildComponent } from './viewChild.component';
import { ViewChildSubComponent } from './viewChild2.component';

// SELECT STARTED COMPONENT USING - bootstrap: [....Component]

@NgModule({
    imports: [BrowserModule, FormsModule],

    declarations: [InputSubComponent, InputComponent, NgModelComponent, ViewChildSubComponent, ViewChildComponent],

    bootstrap: [InputComponent]
})
export class AppModule { }