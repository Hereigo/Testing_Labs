import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'second-component-block',
    template: `
        <h4>This is Second Component.</h4>`,
    styles: [`
        h4 {
            border: 2px solid blue;
            padding: 10px
        }`]
})
export class MySecondComponent implements OnInit {
    // can use for debugging.
    ngOnInit(): void {
        console.log("MY SECOND COMPONENT HAS INITIALISED.");
    }
}