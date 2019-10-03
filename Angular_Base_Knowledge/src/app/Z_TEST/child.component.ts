import { Component, OnInit, Input } from '@angular/core';

@Component({
    selector: 'child-comp-inp',
    template: `
        <p>TEST : {{childInputParam}}</p>
        `
})
export class ChildComponent implements OnInit {
    // can use for debug.
    ngOnInit(): void {
        console.log(" = = = APP COMPONENT HAS INITIALISED !!! = = = ");
    }

    @Input() childInputParam :string;
}