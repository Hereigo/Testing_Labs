import { Component, Input, EventEmitter, Output } from '@angular/core';

@Component({
    selector: 'child-comp-inp',
    template: `
        <div>
        	<span>export class ChildComponent &#123;</span>
        	<p>
        		<strong>. @Input() setter.ToUpperCase()</strong>= {{childInput}}
        	</p>
        	<p>
        		<button (click)="btnClick(childInput)">@Output() EventEmitter.emit( childInput )</button>
        	</p>
        </div>`,
    styles: [`
        button,
        div {
            border: 2px orange solid;
            padding: 10px;
        }`]
})
export class InputSubComponent {

    @Input()
    set childInput(incoming: string) {

        this._childInput = incoming.toUpperCase();
    }
    get childInput() {
        return this._childInput;
    }
    
    _childInput: string;

    @Output() outputToParentEvent = new EventEmitter<number>();

    btnClick(param: number) {
        this.outputToParentEvent.emit(param);
    }
}