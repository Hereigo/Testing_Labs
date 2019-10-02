import { Component } from '@angular/core';

@Component({
    selector: 'my-app-place',
    styles: [` 
            h2{color:blue;}
            :host {font-family: Verdana;}
        `],
    // styles: - FOR THIS TEMPLATE ONLY !!! 
    // styles :host - is for SELECTOR 'my-app-place' element.
    // styleUrls: ['./app.component.css'], - styles can be placed in an outer file
    // templateUrl: './app.component.html', - template can be placed in an outer file
    template: `<label>Введите имя:</label>
                 <input [(ngModel)]="name" placeholder="name">
                 <h2>Добро пожаловать {{name}}!</h2>
                 <br>
                 <input type="text" [value]="name + ' ' + name" [attr.width]="inputWidth"  />
                 <br>
                 <p [textContent]="'Again : ' + name"></p>`
})
export class MyNGComponent {
    name = ''; // default value is empty
    inputWidth = 200;
}

// Components needed to manage of UI views.

// MyNGComponent - my own Class-Component decorated with -
// @Component - function-Decorator (from angular/core) to associate meta-data with MyNGComponent class.

// <h2>Добро пожаловать {{name}}!</h2>  -  one-way DOM to data binding.
// <input type="text" [value]="name" />  -  one-way DOM property to data binding.
// <input [(ngModel)]="name" placeholder="name">  -  two-ways binding.
// <button (click)="addItem(text, price)">Добавить</button>  -  one-way DOM event to component method binding.
