import { Component, Input, Output, EventEmitter } from '@angular/core';
// import { EventEmitter } from 'events'; - WRONG IMPORT !!! 

@Component({
    selector: 'child-compo',
    template: `<div style='border: 2px solid blue; padding:10px'>

        <h4>Child @Input() = {{childInput}}</h4>

        <button (click)="childBtnClick(true)">True!</button>

    </div>`
})
export class ChildComponent {

    // CHILD INPUT PROPERTY :

    _childInput:string;

    @Input() 
        set childInput(inputVar:string){

            this._childInput = inputVar.toUpperCase();
        }
        get childInput(){
            return this._childInput;
        }

    // CHILD OUTPUT VALUE BY EVENT EMISSION :
    
    @Output() childOutput = new EventEmitter<boolean>();

    childBtnClick(clickParam:boolean) {

        this.childOutput.emit(clickParam);
    }

}