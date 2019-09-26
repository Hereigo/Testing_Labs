import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppModComponent } from './app.mod.component';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [AppModComponent],
    bootstrap: [AppModComponent]
})
export class AppModule {}