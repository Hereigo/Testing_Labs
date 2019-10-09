import { Component } from '@angular/core';

@Component({
        selector: 'my-delay-block',
        template: `
                <div *delayDrectiveMark='500'>Element 1</div>
                <div *delayDrectiveMark='1000'>Element 2</div>
                <div *delayDrectiveMark='1500'>Element 3</div>
                <div *delayDrectiveMark='2000'>Element 4</div>
                <div *delayDrectiveMark='2500'>Element 5</div>
                <div *delayDrectiveMark='3000'>Element 6</div>`
})
export class DelayComponent { }