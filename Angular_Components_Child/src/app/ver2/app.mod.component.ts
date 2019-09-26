import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    template: `<h3>{{test}}<h3>`
})
export class AppModComponent {
    test = "Hello from Component!";
}