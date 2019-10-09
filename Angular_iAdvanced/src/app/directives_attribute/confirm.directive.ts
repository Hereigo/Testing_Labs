import { Directive, Input, HostListener } from '@angular/core';

@Directive({
        selector: '[myConfirm]'
})
export class ConfirmDirective {

        @Input('myConfirm')
        onConfirmedInputAction: Function = () => { };

        @HostListener('click')
        onConfirmListenerAction() {

                let isConfirmed = window.confirm('Are you sure?');

                if (isConfirmed) {
                        this.onConfirmedInputAction();
                }
        }
}
