import { Component } from '@angular/core';

// import { DataModule } from './data/data.module'; - In the APP.MODULE - to use <my-data>.

@Component({
    selector: 'my-app',
    template: `
        <div>
            <h3>{{message}}</h3>
            
            <my-data>Please wait ...</my-data>
            
        </div>`,
    styles: [`
        div {
            border: 2px solid green;
            padding: 10px
        }`]
})
export class AppComponent {

    message: string = "In the App Component.";
}