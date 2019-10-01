import { Component, Input, EventEmitter, Output } from '@angular/core';

@Component({
    selector: 'child-comp-inp',
    template: `
        <div id='chi-wrapper'>
        	<h4>export class ChildComponent &#123;</h4>
        	<p>
        		<strong>. @Input() intParam =</strong>{{intParam}}
        	</p>
        	<p>
        		<strong>. @Input() set strParam.ToUpperCase() =</strong>{{strParam}}
        	</p>
        	<p>
        		<button (click)="btnClick(true)">child-Event-Inside-Parent.emit()</button>
        	</p>
        </div>`,
    styles: [`
        #chi-wrapper {
            border: 2px orange solid;
            padding: 0 10px;
        }`]
})
export class ChildComponentInput {

    @Input() intParam: number;

    @Input()
    set strParam(incoming: string) {

        this._childInput = incoming.toUpperCase();
    }
    get strParam() {
        return this._childInput;
    }
    _childInput: string;

    // CHILD OUTPUT VALUE BY EVENT EMISSION :

    @Output() childEventInsideParent = new EventEmitter<boolean>();

    btnClick(clickParam: boolean) {

        this.childEventInsideParent.emit(clickParam);
    }
}