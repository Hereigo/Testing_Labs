import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AbcComponent } from './abc/abc.component';
import { AbcExitGuard } from './abc/abc.exit.guard';
import { AbcGuard } from './abc/abc.guard';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app.routing.module';
import { HomeComponent } from './home/home.component';
import { TestComponent } from './routes/test.component';

@NgModule({
  bootstrap: [AppComponent],
  declarations: [
    AbcComponent,
    AppComponent,
    HomeComponent,
    TestComponent,
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
    FormsModule,
  ],
  providers: [AbcGuard, AbcExitGuard],
})
export class AppModule { }
