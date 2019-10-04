import { Component } from '@angular/core';

// SPECIAL FOR PROMISES & OBSERVABLE for UI 

@Component({
        selector: 'my-app',
        template: `
                <div>
                	<p>
                		<b>Async Pipe testing...</b>
                	</p>
                	<p>
                		<button (click)='getData()' >Send Request</button>
                	</p>
                	<p>
                		<!-- {{ ... | async }} - is for wait promise result b4 assign to var. -->
                		<span>Respons : {{ dataFromServer | async }}</span>
                	</p>
                	<hr/>
                	<p>
                		<part-ll-observable></part-ll-observable>
                	</p>
                </div>`
})
export class AsyncComponent {

        dataFromServer: Promise<string> = null;
        promiseResolve: Function = null;
        promiseFail: Function = null;

        constructor() {

                this.dataFromServer = new Promise<string>((resolve, reject) => {
                        this.promiseResolve = resolve;
                        this.promiseFail = reject;
                });
        }

        getData() {

                setTimeout(() => {
                        this.promiseResolve('Data from server =)');
                }, 3000);
        }
}