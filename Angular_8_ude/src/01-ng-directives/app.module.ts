import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BindingComponent } from './binding/binding.component';
import { NgForNgStyleComponent } from './ngFor-ngStyle/ngFor-ngStyle.component';
import { NgSwitchComponent } from './ng-switch/ng-switch.component';

@NgModule({
  declarations: [
    AppComponent,
    BindingComponent,
    NgForNgStyleComponent,
    NgSwitchComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule_01 { }
