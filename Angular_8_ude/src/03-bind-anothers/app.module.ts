import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { CockpitComponent } from './cockpit.component';
import { ElementComponent } from './one-element.component';
import { NgContentComponent } from './ng-content.component';

@NgModule({
  declarations: [
    AppComponent,
    CockpitComponent,
    ElementComponent,
    NgContentComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
