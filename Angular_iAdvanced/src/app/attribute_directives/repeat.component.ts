import { Component } from '@angular/core';

@Component({
        selector: 'repeater-block',
        template: `
                <div repeatMe message='Hello repeter 3' count='3'></div>
                <repeatMe message='4 Hello repeter' count='4'></repeatMe>`
})
export class RepeatComponent { }