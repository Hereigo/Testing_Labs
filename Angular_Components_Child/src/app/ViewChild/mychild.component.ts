import { Component } from '@angular/core';

@Component({
    selector: 'mychild-component',
    template: `
        <h4>{{mychildText}}</h4>`
})
export class MyChildComponent { 

    mychildText:string = '= mychild-component =';

    childClick() { alert(this.mychildText);}
}