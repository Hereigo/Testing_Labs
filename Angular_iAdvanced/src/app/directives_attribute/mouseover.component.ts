import { Component } from '@angular/core';

@Component({
        selector: 'mouseover-block',
        template: `
                <div myCoords>...</div>`,
        styles: [`
                div {
                    background-color: lightblue;
                    height: 200px;
                    width: 200px;
                }`]
})
export class MouseoverComponent { }