import { Component } from '@angular/core';

// <div *userCardDirecMark='let fn = firstName; let ln = lastName;'>

// this MARK - to get 'firstName' & 'lastName' data from Binded-DIRECTIVE

@Component({
        selector: 'my-context-block',
        template: `
                <div *userCardDirecMark='let fn = firstName; let ln = lastName;'>
                	<p>First name = {{fn}}</p>
                	<p>Last name = {{ln}}</p>
                </div>`
})
export class ContextComponent { }