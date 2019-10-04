import { Component } from '@angular/core';
//import { Subscriber } from 'rxjs/Subscriber';
//import { Observable } from 'rxjs/Observable';
import { Observable, Subscriber } from 'rxjs';

// in case of  - Cannot find module 'rxjs-compat/Observable'
// run : npm install --save rxjs-compat

// SPECIAL FOR PROMISES & OBSERVABLE for UI 

@Component({
        selector: 'part-ll-observable',
        template: `
                <p>
                	<b>Async Pipe testing...</b>
                </p>
                <p>
                	<button (click)='start()' >Start Observer</button>
                </p>
                <p>
                	<!-- {{ ... | async }} - is for wait promise result b4 assign to var. -->
                	<span>Get time form Observer : {{ time | async }}</span>
                </p>`
})
export class AsyncObservableComponent {

        counter: number = 0;
        time: Observable<number>;

        start() {

                this.time = new Observable<number>((timeObserver: Subscriber<number>) => {

                        setInterval(() => {
                                // to send new next data to ALL Subscribers
                                timeObserver.next(this.counter++);
                        }, 1000);

                });
        }
}