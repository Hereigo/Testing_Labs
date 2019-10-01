import { Component } from '@angular/core';

@Component({
    selector: 'mychild-component',
    template: `
        <h4>{{test}}</h4>`
})
export class MyChildComponent { 

    test:string = '= mychild-component =';

    click_onChild() { alert('Yo!');}
}