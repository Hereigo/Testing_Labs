import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { ParentComponent } from './app.component';

@NgModule({
    imports: [BrowserModule, FormsModule],
    exports: [],
    declarations: [ParentComponent],
    bootstrap: [ParentComponent],
    providers: []
})
export class AppModule { }

// AppModule - First Root Module of App !
// MyNGComponent declare as Required & set as Must-Be-Loaded

// bootstrap: to upload "MyNGComponent".
// declarations: to declare View Classes : 
//              - VC of type Components,
//              - VC of type Directives,
//              - VC of type Pipes.