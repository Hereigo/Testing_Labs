import { Component } from '@angular/core';

// <div *userCardDirecMark='let fn = firstName; let ln = lastName;'>

// this MARK - to get 'firstName' & 'lastName' data from Binded-DIRECTIVE

@Component({
        selector: 'my-context-block',
        template: `
                <div *userCardDirecMark='let fn = firstName; let ln = lastName; let dt = registered;'>
                	<p>First name = {{ fn }}</p>
                	<p>Last name = {{ ln | uppercase }}</p>
                	<p>Registered = {{ dt | date | uppercase }}</p>
                </div>`
})
export class ContextComponent { }