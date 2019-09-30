import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { DataComponent } from './data.component';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [DataComponent],
    exports: [DataComponent]       // экспортируем компонент
})
export class DataModule { }